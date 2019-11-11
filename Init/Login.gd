extends Control
var id
var pw
var login
const path = "res://Init/userinfo.txt"
#TODO: 암호화 키 "" > OS.get_unique(ID())로 수정해야 


#저장된 사용자 정보가 있는지 확인, 있으면 그 값으로 입력창을 채움
func _ready():
	var f = File.new()
	#로그인 이력이 있다면
	if f.file_exists(path):
		login = true
		var err = f.open_encrypted_with_pass(path, File.READ, "0")
		#var err = f.open(path, File.READ)
		var data = f.get_var()
		var info = data.split('\n', false, 0)
		f.close()
		id = info[0]
		pw = info[1]
		get_node("user_id").set_text(id)
		get_node("user_pw").set_text(pw)

	if not f.file_exists(path):
		login = false
		#TODO: false이면 회원가입 버튼 활성화, 


func _on_login_pressed():
	if get_node("user_id") != null: 
		id = get_node("user_id").get_text()
	if get_node("user_pw") != null: 
		pw = get_node("user_pw").get_text()

	checkAccount()


func save_userdata(data):
	var f = File.new()
	f.open(path, File.WRITE)
	var err = f.open_encrypted_with_pass(path, File.WRITE, "0")
	#var err = f.open(path, File.WRITE)
	f.store_var(data)
	f.close()


func checkAccount():
	#TODO: 계정 존재하는지 서버에 확인,
	if(id == 'terra' and pw == 'terra'):
		var data = id + '\n' + pw
		save_userdata(data)
		Global.goto_scene("res://SceneFolder/MainScene.tscn")
		
	else:
		#TODO: alert 창 띄우기 
		print('login info is not matched')
		pass