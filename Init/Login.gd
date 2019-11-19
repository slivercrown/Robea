extends Control
var id
var pw
var nickname
const path = "res://Init/userinfo.txt"
#TODO: 암호화 키 "" > OS.get_unique(ID())로 수정해야 
#TODO: 닉네임 우리 필요한가? 필요하면 gdscript수정, 아니면 스키마 수정
#TODO: DELETE 추가?
#TODO: Alert 창 띄우기 

#저장된 사용자 정보가 있는지 확인, 있으면 그 값으로 입력창을 채움
func _ready():
	var f = File.new()
	#로그인 이력이 있다면
	if f.file_exists(path):
		print('chche hit')
		var err = f.open_encrypted_with_pass(path, File.READ, "0")
		#var err = f.open(path, File.READ)
		var data = f.get_var()
		id = data["id"]
		pw = data["pw"]
		f.close()
		get_node("user_id").set_text(id)
		get_node("user_pw").set_text(pw)

	if not f.file_exists(path):
		print('cache miss')
		get_node("signup").visible = true
		get_node("user_nickname").visible = true
		get_node("user_nickname_label").visible = true


func _on_login_pressed():
	if get_node("user_id") != null: 
		id = get_node("user_id").get_text()
	if get_node("user_pw") != null: 
		pw = get_node("user_pw").get_text()
	var data = {"id":id, "pw":pw}
	var query = JSON.print(data)
	
	var connect = load("res://Init/ConnectDB.gd").new()
	var retval = connect.loginGET(query)
	
	if retval == true:
		save_userdata(data)
		Global.goto_scene("res://SceneFolder/MainScene.tscn")
	else:
		#TODO: 로그인실패창 만들기
		get_node("result_label").text = "Invalid ID/PW !!"
		get_node("result_label").visible = true
	
	
func _on_signup_pressed():
	if get_node("user_id") != null: 
		id = get_node("user_id").get_text()
	if get_node("user_pw") != null: 
		pw = get_node("user_pw").get_text()
	if get_node("user_nickname") != null:
		nickname = get_node("user_nickname").get_text()
	var data = {"id":id, "pw":pw, "nickname":nickname}
	var query = JSON.print(data)
	
	var connect = load("res://Init/ConnectDB.gd").new()
	var retval = connect.createAccountPOST(query)
	
	if retval == true: 
		#TODO: 가입성공창 만들기
		data = {"id":id, "pw":pw}
		save_userdata(data)
		get_node("result_label").text = "Account creation success !!"
		get_node("result_label").visible = true
	
	else:
		#TODO: 가입실패창 만들기
		get_node("result_label").text = "Account creation fail !! Please use other ID.."
		get_node("result_label").visible = true


func save_userdata(data):
	var f = File.new()
	f.open(path, File.WRITE)
	var err = f.open_encrypted_with_pass(path, File.WRITE, "0")
	#var err = f.open(path, File.WRITE)
	f.store_var(data)
	f.close()