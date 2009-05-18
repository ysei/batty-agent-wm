# == Schema Information
# Schema version: 20090518160518
#
# Table name: active_forms
#
#  email                 :text
#  password              :text
#  password_confirmation :text
#

# メールサインアップフォーム
class EmailSignupForm < ActiveForm
  column :email,                 :type => :text
  column :password,              :type => :text
  column :password_confirmation, :type => :text

  validates_presence_of :email
  validates_presence_of :password
  validates_presence_of :password_confirmation
  validates_length_of :email, :maximum => 200, :allow_nil => true
  validates_length_of :password, :in => 4..20, :allow_nil => true
  validates_format_of :password, :with => /\A[\x21-\x7E]+\z/
  validates_email_format_of :email
  validates_each(:password) { |record, attr, value|
    # MEMO: validates_confirmation_ofはpassword_confirmation属性を上書きしてしまうため、
    #       ここでは使用できない。そのため、validates_confirmation_ofを参考に独自に実装。
    confirmation = record.__send__("#{attr}_confirmation")
    if confirmation.blank? || value != confirmation
      record.errors.add(attr, :confirmation)
    end
  }
  # TODO: emailが一意であることを検証する

  def masked_password
    return self.password.to_s.gsub(/./, "*")
  end

  def to_email_credential_hash
    return {
      :email           => self.email,
      :hashed_password => EmailCredential.create_hashed_password(self.password.to_s),
    }
  end
end
