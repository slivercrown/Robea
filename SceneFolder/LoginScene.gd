extends Control
var id
var pw

func _ready():
	pass # Replace with function body
	
#TODO: 네트워크 연결 확인 
func _connect():
	var network = NetworkedMultiplayerENet.new()
	network.create_client("127.0.0.1", 4242)
	get_tree().set_network_peer(network)

#사용자 입력 받아서 
func _on_login_pressed():
	if get_node("user_id") != null: 
		id = get_node("user_id").get_text()
	if get_node("user_pw") != null: 
		pw = get_node("user_pw").get_text()
		
	if (checkAccount(id, pw)):	#로그인 성공 시 다음 씬으로 이동 
		Global.goto_scene("res://SceneFolder/MainScene.tscn")
	else:	#로그인 실패 시 alet 띄우기 
		var a

#TODO: 계정 존재하는지 서버에 확인
func checkAccount(id, pw):
	var a
