extends Control
var id
var pw
var nickname
const path = "res://Init/userinfo.txt"
onready var db = get_node("ConnectDB")
onready var check_timer = Timer.new()

#TODO: 암호화 키 "" > OS.get_unique(ID())로 수정해야 
#TODO: DB에서 닉네임 받아오기 + 닉네임을 다른 씬으로 넘겨주기

func _ready(): #저장된 사용자 정보가 있는지 확인, 있으면 그 값으로 입력창을 채움
	check_timer.autostart = true
	check_timer.one_shot = true
	check_timer.connect("timeout", self, "_clear_msg")
	add_child(check_timer)
	
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


func _on_login_pressed():
	if get_node("user_id") != null: 
		id = get_node("user_id").get_text()
	if get_node("user_pw") != null: 
		pw = get_node("user_pw").get_text()
	var data = {"id":id, "pw":pw}
	var query = JSON.print(data)
	var retval = db.loginGET(query)
	
	match retval:
		HTTPClient.RESPONSE_OK:
			save_userdata(data)
			Global.goto_scene("res://SceneFolder/MainScene.tscn")
			
		HTTPClient.RESPONSE_CONFLICT:
			print("login conflict: ", retval)
			get_node("result_label").text = "Oops! Wrong ID/PW! Please check your account info.."
			get_node("result_label").visible = true
			check_timer.start(2)
			
		HTTPClient.RESPONSE_REQUEST_TIMEOUT:
			print("login timeout: ", retval)
			get_node("result_label").text = "Please check your network"
			get_node("result_label").visible = true
			check_timer.start(2)
			
		_:
			print("login default: ", retval)
			get_node("result_label").text = String(retval)
			get_node("result_label").visible = true
			check_timer.start(2)
	
	
func _on_signup_pressed():
	Global.goto_scene("res://Init/SignupScene.tscn")
	
	
func save_userdata(data):
	var f = File.new()
	f.open(path, File.WRITE)
	var err = f.open_encrypted_with_pass(path, File.WRITE, "0")
	f.store_var(data)
	f.close()
	
	
func _clear_msg():
	get_node("result_label").text = ""
	get_node("result_label").visible = false
	