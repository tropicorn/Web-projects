
	
function createOption(which){
		//make a div
		var divEle= document.createElement('div');
		divEle.style.width= "500px";
		divEle.style.position= "relative";
		divEle.style.left= "0px";
		

		//create a select
		var selEle = document.createElement('select');
		selEle.style.width= "200px";


		
		//image element to append at the end
		var anImage= document.createElement('img');
		anImage.setAttribute('alt', "image");
		anImage.setAttribute('id', "aPic");
		anImage.setAttribute('height', "300");
		anImage.setAttribute('width', "200");
		anImage.style.position="relative";

		
		//create a form
		var myForm= document.createElement('form');	
		myForm.setAttribute('name', "myForm");
		myForm.setAttribute('id', "formID");
		myForm.setAttribute('method',"post");
		
		
		//a div to hold the form
		var formDiv= document.createElement('div');
		formDiv.setAttribute('id', 'formDiv');
		
		
		var newName= document.createElement('input');
		newName.setAttribute('type',"text");
		newName.setAttribute('name',"user");

	
		var label1= document.createElement('label');
		label1.appendChild(document.createTextNode("Name here: "));
		
		var email= document.createElement('input');
		email.setAttribute('name', "email");
		email.setAttribute('type',"text");
		email.setAttribute('size', '25');
		
		
		var label2= document.createElement('label');
		label2.appendChild(document.createTextNode( "Enter your email address: "));
		
		//make a text area/comment box
		var comment= document.createElement('textarea');
		comment.setAttribute('name', 'post');
		comment.setAttribute('maxlength', '2000');
		comment.setAttribute('cols', '30');
		comment.setAttribute('rows', '10');
			
		var label3= document.createElement('label');
		label3.appendChild(document.createTextNode("Please type your comment below: "));
			
		var s = document.createElement("input"); //input element, Submit button
		s.setAttribute('type',"button");
		s.setAttribute('value',"Submit");
		
			
		myForm.appendChild(newName);
		myForm.insertBefore(label1, newName);
		
		myForm.appendChild(email);
		myForm.insertBefore(label2, email);
		
		myForm.appendChild(comment);
		myForm.insertBefore(label3, comment);

		
		myForm.appendChild(s);
		
		
		//if object is not undefined, create the options
		if(typeof obj[which] != "undefined"){
		
			divEle.appendChild(document.createTextNode(obj[which][0]));
		
			//find which element in JSON object
			for (var i= 1; i < obj[which].length; i++){
			
				//give each div an ID to the object
				divEle.setAttribute('id', which);
		
				//add option element to select list
				var optEle= document.createElement('option');
				
				//append text to option
				optEle.text= obj[which][i];
				optEle.value= obj[which][i];
				
				selEle.appendChild(optEle);	
				
				//***put FOR loop here if want to make multiple a tags
				var aTag= document.createElement('a');
				aTag.setAttribute('href',"http://games.yahoo.com/game/klondike-solitaire-flash.html");
				
				
				//add an image to the div if first value is null
				if(obj[which][0] == " "){

					anImage.setAttribute('src', "media/" + obj[which][i]);
					
					
					divEle.appendChild(anImage);
					
					//a break
					var br= document.createElement('br');
					
					divEle.appendChild(br);
					divEle.appendChild(document.createTextNode(" You've selected... " + which + "! "));
					
					
					if(obj[which][1] == "oops.png"){
						divEle.appendChild(document.createTextNode("Oops, doesn't seem to be anything here!"));
					}
					
					if(obj[which][1] == "solitaire.jpg"){
						//insert a link with a particular image
						aTag.appendChild(anImage);
						divEle.appendChild(aTag);
					}
					
					
					
					//last option element	
					formDiv.appendChild(myForm);
					document.getElementsByTagName('body')[0].appendChild(formDiv);
					
					
					//rotate the form on mouse event
					if(myForm.addEventListener){
						myForm.addEventListener('mouseover', function(){this.setAttribute('class', " ");});
						myForm.addEventListener('mouseout', function() {this.setAttribute('class', "rotate");});
						

					}else if(myForm.attachEvent){
						myForm.attachEvent('onmouseover', function(){this.setAttribute('class', " ");});
						myForm.attachEvent('onmouseout', function() {this.setAttribute('class', "rotate");});

					}
					
					
					
					
				}else{
					divEle.appendChild(selEle);
					
				}
				
			}//close for loop
		
		}else {
			//do nothing
		}
		
		
		
		//check for an on change event when clicked on a select option
		if (selEle.addEventListener) {
			//remove
			//remove div elements before adding to the page
			selEle.onchange = function(){

		
			var div = this.parentElement;
			var sibling;
				 
				//while div has next sibling
				while(sibling = div.nextSibling){
					sibling.parentElement.removeChild(sibling);
				}

			}
			
			//create a div on change
			selEle.addEventListener('change', function(){createOption(this.value);});
			
			
		} else if(selEle.attachEvent){
			//in IE 7
			selEle.attachEvent('onchange', function(){createOption(this.value);});
		
		} 
		

		//append div to the body
		document.getElementsByTagName('body')[0].appendChild(divEle);	
		

		//this will animate the div!!
		slideLeft(divEle.id);
	
		//store form values in a cookie
		if(newName = GetCookie("user")){
			document.myForm.user.value = newName;
		}
								
		if(email= GetCookie("email")){
			document.myForm.email.value = email;
								
		}
								
		if(comment= GetCookie("post")){
			document.myForm.post.value = comment;
							
		}
		
		
		//last option, displays a form
		if (s.addEventListener) {
				s.addEventListener('click', function(){validateForm();});
				s.addEventListener('click', function(){storeValues(myForm);});

				
		} else if(s.attachEvent){
			//in IE
			s.attachEvent('onclick', function(){validateForm();});
		}

	
}



//validate form input
function validateForm()
{
	var x= document.myForm.user.value;
	var y= document.myForm.email.value;
	var z= document.myForm.post.value;
	
	console.log(x);
	
	var atSign = y.indexOf("@");
	var dotNote = y.lastIndexOf(".");
	
	if (x == null || x == "")
	{
		alert("Name field must be filled out");
		document.myForm.user.focus();
		return false;
	}
	
	if (y == null || y == "")
	{
		alert("Email is left blank!");
		document.myForm.email.focus();
		return false;
	
	}else if (atSign < 1 || ( dotNote - atSign < 2 )) {
		//if missing an @ sign or a dot com
		alert("Please enter a correct email format")
		document.myForm.email.focus() ;
		return false;
	}
	
	if (z == null || z == ""){
		alert("Please enter some comments! ");
		document.myForm.comment.focus();
		return false;
	
	}else{
		alert("Enjoy your selection!");
	
	}

	return false;
	
}

function slideLeft(id)
{
	var d = document.getElementById(id);
	
	if(parseInt(d.style.left) < 50)
	{
		d.style.left = parseInt(d.style.left) + 1 + 'px';
		setTimeout(function(){slideLeft(id);}, 5);
	}
}





