document.addEventListener("DOMContentLoaded", ()=>
{
    document.querySelector("#AddPacient").addEventListener("click", async()=> await AddPacient())
}
);
 async function  AddPacient()
 {
     if (document.querySelector("#F").value == "" || document.querySelector("#I").value == "" || document.querySelector("#O").value == "" || document.querySelector("#DateBorn").value == "" ||document.querySelector("#Job").value == ""||document.querySelector("#Email").value == ""||document.querySelector("#Phone").value == ""||document.querySelector("#PasportSeria").value == ""||document.querySelector("#PasportAdres").value == "")
     {
        alert("Заполните все поля")
        return false;
     }
   

    
        F = document.querySelector("#F").value;
        I = document.querySelector("#I").value;
        O = document.querySelector("#O").value;
        DateBorn = document.querySelector("#DateBorn").value;
         Job = document.querySelector("#Job").value;
        PasportSeria = document.querySelector("#PasportSeria").value;
        PasportAdres = document.querySelector("#PasportAdres").value;
        Phone = document.querySelector("#Phone").value;
     Email = document.querySelector("#Email").value;

        const myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

         const raw = JSON.stringify({
            "F":F,
            "I":I,
            "O":O,
            "DateBorn":DateBorn,
            "Job":Job,
            "PasportSeria":PasportSeria,
            "PasportAder":PasportAdres,
            "Phone":Phone,
            "Email":Email
        });

        const requestOptions = {
          method: "POST",
         headers: myHeaders,
        body: raw,
          redirect: "follow"
        };

     await fetch("/PacientsController/Create", requestOptions)
         .then((response) => response.json())
         .then((result) => {
             if (result.statusCode == 200) {
                 alert("Пациент добавлен")
             }
         });
  
    
}
