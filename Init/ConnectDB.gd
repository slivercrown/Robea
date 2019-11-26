extends HTTPRequest
const url = "101.101.160.229"
const port = 5000
var header = ["Content-Type: application/json"]
var RESPONSE = 0
var HTTP = null
	
func _init():
	HTTP = HTTPClient.new()
	RESPONSE = HTTP.connect_to_host(url, port, false)
	
	# Wait until resolved and connected
	var timeout = 0
	while(HTTP.get_status() == HTTPClient.STATUS_CONNECTING or HTTP.get_status() == HTTPClient.STATUS_RESOLVING):
		HTTP.poll()
		print("DB Connecting...")
		timeout += 50
		OS.delay_msec(50) 
		if timeout >= 500: 
			print("DB connection timeout !!!")
			return HTTPClient.RESPONSE_REQUEST_TIMEOUT	
	
	# Error catch: Could not connect
	if HTTP.get_status() != HTTPClient.STATUS_CONNECTED:
		HTTP.close() 
		HTTP = null
		return HTTP.get_status()
	assert(HTTP.get_status() == HTTPClient.STATUS_CONNECTED)

# >> 회원가입 이렇게 할래	
func createAccountPOST(data):
	if (HTTP == null):
		_init()
	RESPONSE = HTTP.request(HTTPClient.METHOD_POST, "/", header, data)

	# Make sure all is OK
	if(RESPONSE != OK):
		print("signup default here: ")
		HTTP.close() 
		HTTP = null
		return RESPONSE
	assert(RESPONSE == OK)
	
	# Keep polling until the request is going on
	var timeout = 0
	while (HTTP.get_status() == HTTPClient.STATUS_REQUESTING):
		HTTP.poll()
		print("POST Requesting...")
		timeout += 50
		OS.delay_msec(50)
		if timeout >= 500: 
			print("POST connection timeout !!!")
			HTTP.close() 
			HTTP = null
			return HTTPClient.RESPONSE_REQUEST_TIMEOUT
	
	# Make sure request finished
	if HTTP.get_status() != HTTPClient.STATUS_BODY and HTTP.get_status() != HTTPClient.STATUS_CONNECTED:
		print ("Signup assert: ", HTTP.get_status())
		HTTP.close()
		var status = HTTP.get_status()
		HTTP = null
		return status
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
		print("POST result: ", result["StatusCode"])
		
		# << ㅇㅇ 만들어짐
		if result["StatusCode"] == String(HTTPClient.RESPONSE_OK):
			HTTP.close()
			return HTTPClient.RESPONSE_OK
		
		# << ㄴㄴ 중복이다 
		else:
			HTTP.close()
			return HTTPClient.RESPONSE_CONFLICT
			
	else:
		HTTP.close()
		return HTTPClient.RESPONSE_NO_CONTENT
		
		
# >> 이런 계정으로 로그인 한대
func loginGET(data):
	if (HTTP == null):
		_init()
	RESPONSE = HTTP.request(HTTPClient.METHOD_GET, "/", header, data)
	
	# Make sure all is OK
	if(RESPONSE != OK):
		print("login default here: ")
		HTTP.close() 
		HTTP = null
		return RESPONSE
	assert(RESPONSE == OK)
	
	# Keep polling until the request is going on
	var timeout = 0
	while (HTTP.get_status() == HTTPClient.STATUS_REQUESTING):
		HTTP.poll()
		print("GET Requesting...")
		timeout += 50
		OS.delay_msec(50)
		if timeout >= 500:
			print("GET connection timeout !!!")
			HTTP.close() 
			HTTP = null
			return HTTPClient.RESPONSE_REQUEST_TIMEOUT
	
	# Make sure request finished
	if (HTTP.get_status() != HTTPClient.STATUS_BODY and HTTP.get_status() != HTTPClient.STATUS_CONNECTED):
		print ("Login assert: ", HTTP.get_status())
		HTTP.close()
		var status = HTTP.get_status()
		HTTP = null
		return status
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
		print("GET result: ", result["StatusCode"])
		
		# << ㅇㅇ 로그인 성공
		if result["StatusCode"] == String(HTTPClient.RESPONSE_OK):
			HTTP.close() 
			HTTP = null
			return HTTPClient.RESPONSE_OK
		
		# << ㄴㄴ 로그인 정보 안 맞는다 
		else:
			HTTP.close() 
			HTTP = null
			return HTTPClient.RESPONSE_CONFLICT

	else:
		HTTP.close() 
		HTTP = null
		return HTTPClient.RESPONSE_NO_CONTENT