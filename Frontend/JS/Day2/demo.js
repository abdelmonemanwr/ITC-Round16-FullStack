// function funName(a,b){body}

// function sum(){
//     var a = 23;
//     var b = 24;
//     var c = a + b;  
//     return c;
// }

// var output = sum();
// console.log(output)
// console.log(sum)

// function sum2(){
//     var a = 35;
//     var b = 346;
//     var c = a + b;  
//     return c;
// }


// function sum(x, y){
//     x = x || 0;
//     y = y || -1;
//     console.log("x=",x);
//     console.log("y=",y);
//     // console.log("arguments=",arguments);
//     console.log("output=",x+y);
//     return  x + y;
// }

// console.log(sum(2,6));
// console.log(sum(5));
// console.log(sum());
// console.log(sum(45,23,"345",function (){console.log("hello");}));
// sum("mona", "ali")
// sum("mona", 23);
// var ret = sum(true, true);
// console.log("ret=",ret);

// test();


// function statment (function declration)
// function expression

// var exp = 4+6;
// var result = function sum(a,b){
//     return a+b;
// };
// var result = function (a,b){
//     return a+b;
// };

// sum(2,3);   
// var res = result(2,3);   
// console.log("res=",res);

// ()=>{}
// delegate (int x, int y){
//    return x+y;
// }


// var result = function (x,y){
//     console.log(x+y);
// }

// var res = result(2,3);
// console.log("res=",res);

// console.log("age=",age);
// var age = 34;

// console.log("age=",age);
// let age = 34;

// console.log(abc);

// console.log(window);
// console.log(this);


// declaration phase
   // create global execution context
   // create global object  called window
   // create a special object called this and assign it to window
   // hoist all the function and variable declarations
// execution phase

// let x = 34;

// console.log(fname);
// var fname = "men3m";

// add(2,5);
// function add(a,b){
//     console.log(a+b);
// }

// // result(2,5);
// var result = function (a,b){
//     console.log(a+b);
// }

// console.log(x);
// const x = 23;

function greet(x){
    console.log("wlcm", x);
    x();
}

// greet("shahd")
// greet(34)
// greet(true)
// greet({fnme:"shahd", lname:"ali"})

// greet(function (){
//     console.log("hello from callback function");
// });


// console.log(navigator.geolocation.getCurrentPosition(successCB, errorCB));


// function successCB (){
//     console.log("pos");
// }

// function errorCB(){
//     console.log("can't fetch your position");
// }


// setTimeout(() => {
//     console.log("hello from setTimeout");
// }, 2000);

// var i = 0;
// let intervalId = setInterval(() => {
//     i++;
//     console.log("hello from setInterval", i);
//     if(i==10){
//         clearInterval(intervalId);
//     }
// }, 1000);

// ()
// (cb, num)
// (cb, cb)

//.//////////////////////////////////
// key:value,
// var person = {
//     fname: "men3m",
//     lname: "anwar",
//     age: "25",
//     address: {
//         city: "benha",
//         street: "vellal",
//         postalCode: "235534",
//     },
//     gender: true,
//     myKey: "test"
// }

// console.log(person) // get

// dot notation
// console.log(person.fname)
// console.log(person.lname)
// console.log(person.age)
// console.log(person.address)

// Subscript Notation
// console.log(person["fname"])
// console.log(person["lname"])
// console.log(person["age"])
// console.log(person["address"]["city"])
// console.log(person["address"]["postalCode"])
// console.log(person["address"].street)
// console.log(person.address["postalCode"])

// person.age=35;
// console.log(person.color);

// person.color = "blue";
// console.log(person);



// var myKey = "age";
// console.log(person.myKey);  // person.age: undefined
// console.log(person[myKey]); // person["age"]=25
// console.log(person["myKey"]); // undefined

///////////////////////////////////////////////

// console.log(document)

// var element = document.getElementById("head1");
// console.log(element);

// var elements = document.getElementsByClassName("content");
// console.log(elements);

// for(var i=0; i<elements.length; i++){
    //     console.log(elements[i]);
// }

// var elements = document.getElementsByName("testValue");
// console.log(elements[0]);

// var elements = document.getElementsByTagName("p");
// console.log(elements);

// var element = document.querySelector("#head1");
// console.log(element);
// var element = document.querySelector("#btn");
// console.log(element);
// var element = document.querySelector(".content");
// console.log(element);
// var element = document.querySelector(".container");
// console.log(element);
// var elements = document.querySelectorAll(".content");
// console.log(elements);


// /////////////////////////////////////////////////

// console.log(document.body);
// console.log(document.links);
// console.log(document.images);
// console.log(document.forms);

var element = document.querySelector(".container");
// // console.log(element)
// console.log(element.firstChild);
// console.log(element.firstElementChild);

// console.log(element.lastChild);
// console.log(element.lastElementChild);

// //////////////////////////////////////////


function getText(){
    var container = document.querySelector(".container");
    var pContent = document.getElementsByClassName("content")[1];

    // console.log(pContent.innerHTML)
    // console.log(pContent.innerText)
    console.log(pContent.textContent)

    pContent.style.backgroundColor = "red";
    pContent.style.color = "black";
    // container.style.padding = 5;

    // pContent.classList.add("my-text");
    pContent.className="my-text";
    console.log(pContent);
}

// Change Style:
// > style
// > classList
// > className