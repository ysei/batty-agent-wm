
# メールアクション編集フォーム
class EmailActionEditForm < ActiveForm
  column :enable,  :type => :boolean
  column :email,   :type => :text
  column :subject, :type => :text
  column :body,    :type => :text

  validates_presence_of :email
  validates_presence_of :subject
  validates_presence_of :body
  validates_length_of :email, :maximum => 200, :allow_nil => true
  validates_length_of :subject, :maximum => 200, :allow_nil => true
  validates_length_of :body, :maximum => 1000, :allow_nil => true
  validates_email_format_of :email
end
