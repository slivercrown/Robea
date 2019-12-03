extends Control
var id
var pw
onready var check_timer = Timer.new()

#TODO: Login.gd 참조 

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
	var email = $user_id.text
	var password = $user_pw.text
	Firebase.Auth.signup_with_email_and_password(email, password)


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