extends Control
var google = null

func init():
	get_node("CheckNetwork")._ready()

func _on_HTTPCheckNetwork_connection_success():
	#단말이 NW 연결 됐으면 > 로그인 씬으로
	print('before gpgs')
	#OS.shell_open("http://localhost:5000")
	Global.goto_scene("res://Init/LoginScene.tscn")


func _on_HTTPCheckNetwork_error_connection_failed(code, message):
	#단말이 NW 연결 됐으면 > 에러 
	print('Please check your Network Connection...')

##TODO: 네트워크 연결 확인 
#func _connect():
#	var network = NetworkedMultiplayerENet.new()
#	network.create_client("127.0.0.1", 4242)
#	get_tree().set_network_peer(network)