extends Control

func init():
	# call CheckNetwork()
	get_node("HTTPCheckNetwork")._ready()	

func _on_HTTPCheckNetwork_connection_success():
	#단말이 NW 연결 됐으면 > 로그인 씬으로
	Global.goto_scene("res://SceneFolder/LoginScene.tscn ")
	pass 

func _on_HTTPCheckNetwork_error_connection_failed(code, message):
	#단말이 NW 연결 됐으면 > 에러 
	pass

#로그인 상태 확인해서 
#로그인 기록이 있으면	> 바로 메인씬
#로그인 기록이 없으면 	> 회원가입씬
#
#회원가입씬에선 뭘 해주지?

#No loader found for resource: res://SceneFolder/LoginScene.tscn 
#Attempt to call function 'instance' in base null instance on a null instance
#>> Create any scene and play it. Select 'root' viewport.