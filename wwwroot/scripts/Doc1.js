document.addEventListener("DOMContentLoaded", ()=>
{
  document.querySelector("#Doc1").addEventListener("click", async()=> Doc1())
}
);
function Doc1()
{
    if(document.querySelector("#F").value == ""||document.querySelector("#I").value == ""||document.querySelector("#O").value == ""||document.querySelector("#PasportSeria").value == ""||document.querySelector("#PasportAdres").value == "")
    {
        alert("Заполните форму!")
    }
    else
    {
        let data1 = document.querySelector("#F").value;
        let data2 = document.querySelector("#I").value;
        let data3 = document.querySelector("#O").value;
        let data4 = document.querySelector("#PasportSeria").value;
        let data5 = document.querySelector("#PasportAdres").value;
        sessionStorage.setItem("case1", data1)
        sessionStorage.setItem("case2", data2)
        sessionStorage.setItem("case3", data3)
        sessionStorage.setItem("case4", data4)
        sessionStorage.setItem("case5", data5)
        window.open("Document1.html")
    }
    
  
    
}




document.addEventListener("DOMContentLoaded", ()=>
{
  document.querySelector("#Doc2").addEventListener("click", async()=> Doc2())
}
);
function Doc2()
{
    if(document.querySelector("#F").value == ""||document.querySelector("#I").value == ""||document.querySelector("#O").value == ""||document.querySelector("#PasportSeria").value == ""||document.querySelector("#PasportAdres").value == "")
    {
        alert("Заполните форму!")
    }
    else
    {
        let data1 = document.querySelector("#F").value;
        let data2 = document.querySelector("#I").value;
        let data3 = document.querySelector("#O").value;
        let data4 = document.querySelector("#PasportSeria").value;
        let data5 = document.querySelector("#PasportAdres").value;
        window.open("Document2.html")
    }
    
  
    
}