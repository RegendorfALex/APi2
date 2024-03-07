document.addEventListener("DOMContentLoaded", ()=>
{
   let data1 = sessionStorage.getItem("case1")
   let data2 = sessionStorage.getItem("case2")
   let data3 = sessionStorage.getItem("case3")
   let data4 = sessionStorage.getItem("case4")
   let data5 = sessionStorage.getItem("case5")

   let value1 = document.querySelector("#vivod1");
   let value2 = document.querySelector("#vivod2");
   let value3 = document.querySelector("#vivod3");
   let value4 = document.querySelector("#vivod4");
   let value5 = document.querySelector("#vivod5");

   value1.innerText = data1;
   value2.innerText = data2;
   value3.innerText = data3;
   value4.innerText = data4;
   value5.innerText = data5;
}
);