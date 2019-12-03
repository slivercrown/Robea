extends Control
var id
var pw
onready var check_timer = Timer.new()

#TODO: 로그인 정보 캐쉬 처리 
#TODO: Firebase Database에 닉네임 저장 

func _ready():
	check_timer.autostart = true
	check_timer.one_shot = true
	check_timer.connect("timeout", self, "_clear_msg")
	add_child(check_timer)
	Firebase.Auth.connect("login_succeeded", self, "_on_FirebaseAuth_login_succeeded")
	Firebase.Auth.connect("login_failed", self, "on_login_failed")


func _on_login_pressed():
	var email = $user_id.text
	var password = $user_pw.text
	Firebase.Auth.login_with_email_and_password(email, password)


func _on_signup_pressed():
	Global.goto_scene("res://Init/SignupScene.tscn")


func _on_FirebaseAuth_login_succeeded(auth):
	Global.goto_scene("res://SceneFolder/MainScene.tscn")
	hide()

    
func on_login_failed(error_code, message):
	get_node("result_label").text = "error code: " + str(error_code) + ", message: " + str(message)
	get_node("result_label").visible = true
	check_timer.start(2)
	

func _clear_msg():
	get_node("result_label").text = ""
	get_node("result_label").visible = false

"""
const path = "res://Init/userinfo.txt"
func _ready():
	var f = File.new()
	
	if f.file_exists(path):	#로그인 이력이 있다면
		print('chche hit')
		var err = f.open_encrypted_with_pass(path, File.READ, "0")
		var data = f.get_var()
		id = data["id"]
		pw = data["pw"]
		f.close()
		get_node("user_id").set_text(id)
		get_node("user_pw").set_text(pw)

	if not f.file_exists(path):
		print('cache miss')

func save_userdata(data):
	var f = File.new()
	f.open(path, File.WRITE)
	var err = f.open_encrypted_with_pass(path, File.WRITE, "0")
	f.store_var(data)
	f.close()
"""