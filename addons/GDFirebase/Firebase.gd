extends Node

onready var Auth = HTTPRequest.new()
onready var Database = Node.new()
onready var Firestore = Node.new()
onready var Storage = HTTPRequest.new()

# Configuration used by all files in this project
# These values can be found in your Firebase Project
# See the README on Github for how to access
# https://github.com/WolfgangSenff/GodotFirebase/
onready var config = {
  }
  
func _ready():
    Auth.set_script(preload("res://addons/GDFirebase/FirebaseAuth.gd"))
    Database.set_script(preload("res://addons/GDFirebase/FirebaseDatabase.gd"))
    Firestore.set_script(preload("res://addons/GDFirebase/FirebaseFirestore.gd"))
    Storage.set_script(preload("res://addons/GDFirebase/FirebaseStorage.gd"))
    Auth.set_config(config)
    Database.set_config(config)
    Firestore.set_config(config)
    Storage.set_config(config)
    add_child(Auth)
    add_child(Database)
    add_child(Firestore)
    add_child(Storage)
    Auth.connect("login_succeeded", Database, "_on_FirebaseAuth_login_succeeded")
    Auth.connect("login_succeeded", Firestore, "_on_FirebaseAuth_login_succeeded")
    Auth.connect("login_succeeded", Storage, "_on_FirebaseAuth_login_succeeded")