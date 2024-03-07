document.addEventListener("DOMContentLoaded", ()=>
{
    document.querySelector("#AddGospitalisation").addEventListener("click", async()=> await AddGospitalisation())
}
);
 async function  AddGospitalisation()
{
   

    
        PolisNumber = document.querySelector("#PolisNumber").value;
        PolisCompany = document.querySelector("#PolisCompany").value;
        PolisStart = document.querySelector("#PolisStart").value;
        PolisEnd = document.querySelector("#PolisEnd").value;
        Diagnos = document.querySelector("#Diagnos").value;
        Status = document.querySelector("#Status").value;

        const myHeaders = new Headers();
        myHeaders.append("Content-Type", "application/json");

         const raw = JSON.stringify({
            "PolisNumber" : PolisNumber,
            "PolisCompany": PolisCompany,
            "PolisStart": PolisStart,
            "PolisEnd": PolisEnd,
            "Diagnos": Diagnos,
            "Status": Status
            
        });

        const requestOptions = {
          method: "POST",
         headers: myHeaders,
        body: raw,
          redirect: "follow"
        };

        await fetch("/GospatalisationsController/Create", requestOptions)
      .then((response) => response.json())
     .then((result) => {
          if (result.statusCode == 200)
          {
             alert("Госпитализация создана")
          }
        })
      .catch((error) => console.error(error)); 
  
    
}
