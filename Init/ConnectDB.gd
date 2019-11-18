extends HTTPRequest
var url = "101.101.160.229:5000"
var header = ["Content-Type: application/json"]
var RESPONSE = 0
var HTTP = 0

func _init():
	HTTP = HTTPClient.new()
	RESPONSE = HTTP.connect_to_host("101.101.160.229", 5000, false)
	
	# Wait until resolved and connected
	var timeout = 0
	while(HTTP.get_status() == HTTPClient.STATUS_CONNECTING or HTTP.get_status() == HTTPClient.STATUS_RESOLVING):
	    HTTP.poll()
	    print("Connecting...")
	    OS.delay_msec(10) 
	    timeout += 10
	    if timeout > 1000: 
	    	print("connection timeout !!!")
	    	break
		
	
	# Error catch: Could not connect
	assert(HTTP.get_status() == HTTPClient.STATUS_CONNECTED)

# >> 회원가입 이렇게 할래	
func createAccountPOST(data):
	# Check for a GET or POST command
	if data == "":
	    header =["User-Agent: Pirulo/1.0 (Godot)", "Accept: */*"]
	    RESPONSE = HTTP.request(HTTPClient.METHOD_GET, url, header)
	else:
	    #QUERY = HTTPClient.query_string_from_dict(data)
		RESPONSE = HTTP.request(HTTPClient.METHOD_POST, "/", header, data)
	
	# Make sure all is OK
	assert(RESPONSE == OK)
	print("Connected!")
	
	# Keep polling until the request is going on
	var timeout = 0
	while (HTTP.get_status() == HTTPClient.STATUS_REQUESTING):
	    HTTP.poll()
	    print("Requesting...")
	    OS.delay_msec(10)
	    timeout += 10
	    if timeout > 1000: 
	    	print("connection timeout !!!")
	    	break
	
	# Make sure request finished
	assert(HTTP.get_status() == HTTPClient.STATUS_BODY or HTTP.get_status() == HTTPClient.STATUS_CONNECTED)
	
	#바디 분석
	if HTTP.has_response():
		if HTTP.is_response_chunked():
			pass
		else:
			var bodyLength = HTTP.get_response_body_length()
			
		var bodyArray = PoolByteArray()
		while HTTP.get_status() == HTTPClient.STATUS_BODY:
			HTTP.poll()
			var chunk = HTTP.read_response_body_chunk()
			if chunk.size() == 0:
				pass
			else:
				bodyArray += chunk
				
		var bodyText = bodyArray.get_string_from_ascii()
		var bodyJson = JSON.parse(bodyText)
		var result = bodyJson.result
		print(result["StatusCode"])
		
		# << ㅇㅇ 만들어짐
		if result["StatusCode"] == "200":
			return true
		
		# << ㄴㄴ 중복이다 
		else:
			return false
			
	
# >> 이런 계정으로 로그인 한대
func loginGET(data):
	# Check for a GET or POST command
	if data == "":
	    header =["User-Agent: Pirulo/1.0 (Godot)", "Accept: */*"]
	    RESPONSE = HTTP.request(HTTPClient.METHOD_GET, url, header)
	else:
	    #QUERY = HTTPClient.query_string_from_dict(data)
		RESPONSE = HTTP.request(HTTPClient.METHOD_GET, "/", header, data)

		print(".request RESPONSE: ", RESPONSE)
	
	# Make sure all is OK
	assert(RESPONSE == OK)
	print("Connected!")
	
	# Keep polling until the request is going on
	var timeout = 0
	while (HTTP.get_status() == HTTPClient.STATUS_REQUESTING):
	    HTTP.poll()
	    print("Requesting...")
	    OS.delay_msec(10)
	    timeout += 10
	    if timeout > 1000: 
	    	print("connection timeout !!!")
	    	break
	
	# Make sure request finished
	assert(HTTP.get_status() == HTTPClient.STATUS_BODY or HTTP.get_status() == HTTPClient.STATUS_CONNECTED)
	
	#바디 분석
	if HTTP.has_response():
		if HTTP.is_response_chunked():
			pass
		else:
			var bodyLength = HTTP.get_response_body_length()
			
		var bodyArray = PoolByteArray()
		while HTTP.get_status() == HTTPClient.STATUS_BODY:
			HTTP.poll()
			var chunk = HTTP.read_response_body_chunk()
			if chunk.size() == 0:
				pass
			else:
				bodyArray += chunk
				
		var bodyText = bodyArray.get_string_from_ascii()
		var bodyJson = JSON.parse(bodyText)
		var result = bodyJson.result
		print(result["StatusCode"])
		
		# << ㅇㅇ 로그인 성공
		if result["StatusCode"] == "200":
			return true
		
		# << ㄴㄴ 로그인 정보 안 맞는다 
		else:
			return false