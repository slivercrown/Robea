extends Control

onready var alert = get_node("alert")

func _ready():
	IAP.set_auto_consume(false)
	IAP.connect("purchase_success", self, "on_purchase_success")
	IAP.connect("purchase_fail", self, "on_purchase_fail")
	IAP.connect("purchase_cancel", self, "on_purchase_cancel")
	IAP.connect("purchase_owned", self, "on_purchase_owned")
	IAP.connect("has_purchased", self, "on_has_purchased")
	IAP.connect("consume_success", self, "on_consume_success")
	IAP.connect("consume_fail", self, "on_consume_fail")
	IAP.connect("sku_details_complete", self, "on_sku_details_complete")
	
	get_node("purchase").connect("pressed", self, "button_purchase")
	get_node("consume").connect("pressed", self, "button_consume")
	get_node("request").connect("pressed", self, "button_request")
	get_node("query").connect("pressed", self, "button_query")
	

func _on_Button_pressed():
	Global.goto_scene("res://SceneFolder/MainScene.tscn")

func _on_Button2_pressed():
	Global.goto_scene("res://SceneFolder/MainScene.tscn")
	
func _on_Button3_pressed():
	get_node("Explain_sprite").visible = true

func _on_Button4_pressed():
	pass