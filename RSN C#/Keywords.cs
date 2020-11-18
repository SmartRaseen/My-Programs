	
	
	C# Keywords
	***********
	
	*	C# contains reserved words, that have special meaning for the compiler. These reserved words are called "keywords".
		
	*	Keywords cannot be used as a name (identifier) of a variable, class, interface, etc.


	Keywords in C# are distributed under the following categories:
	**************************************************************
	
	*	Modifier Keywords
		*****************
		
	*	Modifier keywords are certain keywords that indicate who can modify types and type members. 
	
	*	Modifiers allow or prevent certain parts of programs from being modified by other parts.
	
		Modifier keywords
		*****************
		
		*	abstract	-	Learn		
		*	async		-	Learn
		*	const		
		*	event		
		*	extern		-	Learn
		*	new
		*	override	
		*	partial
		*	readonly
		*	sealed		-	Learn
		*	static
		*	unsafe		-	Learn
		*	virtual		-	Learn
		*	volatile	-	Learn
		
----------------------------------------------------------------------------------------------------------------------------------------------------------------	
        
		Access Modifier Keywords:
		************************
		
	*	Access modifiers are applied on the declaration of the class, method, properties, fields and other members. 
	
	*	They define the accessibility of the class and its members.

		
		Access Modifiers		Usage
		
		public					The Public modifier allows any part of the program in the same assembly or 
								another assembly to access the type and its members.

		private					The Private modifier restricts other parts of the program from accessing the type and its members. 
								Only code in the same class or struct can access it.

		internal				The Internal modifier allows other program code in the same assembly to access the type or its members. 
								This is default access modifiers if no modifier is specified.
		
		protected				The Protected modifier allows codes in the same class or 
								a class that derives from that class to access the type or its members.
								
----------------------------------------------------------------------------------------------------------------------------------------------------------------	

		Statement Keywords
		******************
		
	Statement keywords are related to program flow.

	Statement Keywords
	
	*	if
	*	else
	*	switch
	*	case
	*	do
	*	for
	*	foreach
	*	in
	*	while
	*	break
	*	continue
	*	default
	*	goto		- 	Learn
	*	return	
	*	yield		-	Learn
	*	throw
	*	try
	*	catch
	*	finally		-	Learn
	*	checked		-	Learn
	*	unchecked	-	Learn
	*	fixed		-	Learn
	*	lock		-	Learn
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------		

	Method Parameter Keywords
	*************************
	
	*	These keywords are applied on the parameters of a method.

	Method Parameter Keywords
	*************************
		
	*	params
	*	ref
	*	out
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------			
	
	Namespace Keywords
	******************
	
	*	These keywords are applied with namespace and related operators.

		Namespace Keywords
		
		*	using
		*	. operator
		*	:: operator
		*	extern alias
		
----------------------------------------------------------------------------------------------------------------------------------------------------------------				
	
	Operator Keywords
	*****************

	*	Operator keywords perform miscellaneous actions.

		Operator Keywords
		
		*	as		-	
		*	await	- 	Learn
		*	is		-	
		*	new	
		*	sizeof	-	
		*	typeof	-	Learn
		*	stackalloc	-	Learn
		*	checked		-	Learn
		*	unchecked	-	Learn
		
----------------------------------------------------------------------------------------------------------------------------------------------------------------			

	Access Keywords
	***************
	
	*	Access keywords are used to access the containing class or the base class of an object or class.

	Access keywords
	
	*	base
	*	this
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------			

	Literal Keywords
	****************
	
	*	Literal keywords apply to the current instance or value of an object.

	Literal Keywords
	
	*	null
	*	false
	*	true
	*	value
	*	void	
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------			

	Type Keywords
	*************
	
	*	Type keywords are used for data types.

	Type keywords
	
	*	bool
	*	byte
	*	char
	*	class
	*	decimal
	*	double
	*	enum
	*	float
	*	int
	*	long
	*	sbyte
	*	short
	*	string
	*	struct
	*	uint
	*	ulong
	*	ushort	
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------			
	
	Contextual Keywords
	*******************
	
	*	Contextual keywords are considered as keywords, only if used in certain contexts. 
	*	They are not reserved and so can be used as names or identifiers.

	Contextual Keywords
	
	*	add
	*	var
	*	dynamic
	*	global
	*	set
	*	value
	
	*	Contextual keywords are not converted into blue color (default color for keywords in visual studio) when used as an identifier in Visual Studio. For example, var in the below figure is not in blue color whereas color of this is blue color. So var is a contextual keyword
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------			

	Query Keywords
	**************
	
	*	Query keywords are contextual keywords used in LINQ queries.

	Query Keywords
	
	*	from
	*	where
	*	select
	*	group
	*	into
	*	orderby
	*	join
	*	let
	*	in
	*	on
	*	equals
	*	by
	*	ascending
	*	descending
	
----------------------------------------------------------------------------------------------------------------------------------------------------------------			
	