extends Control
var google = null
const default_time = 3
var time = 0

func _ready():
	Bgm._music_stop()


func init():
	get_node("CheckNetwork")._ready()
	
func _process(delta):
	time += delta
	$TextureProgress.updateTime()

func _on_HTTPCheckNetwork_connection_success():
	#단말이 NW 연결 됐으면 > 로그인 씬으로
	#OS.shell_open("http://localhost:5000")
	Global.goto_scene("res://Init/LoginScene.tscn")


func _on_HTTPCheckNetwork_error_connection_failed(code, message):
	#단말이 NW 연결 됐으면 > 에러 
	print('Please check your Network Connection...')