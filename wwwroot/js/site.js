const caracteresEspeciales = ['!','@','#','$','%','^','&','*','(',')','_','-','+','=','{','}','[',']',':',';','"',"'",'<','>',',','.','/','\\','|','?','~','`','¡','¿'];


function ChequearRegistro(){
    var contra1=null;
    var contra2=null;
    var telefono=null;
    let contiene=false;

    contra1=document.getElementById("ContraseñaRegistrar1").value;
    contra2=document.getElementById("ContraseñaRegistrar2").value;
    telefono=document.getElementById("telefono").value;

    console.log(contra1+" "+contra2+" "+telefono);

    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if(contra1.Contains(caracteresEspeciales[i])){contiene=true;}
    }

    if(contra1==contra2 && contra1.length>=8 && contiene){
        if(contra1!=toLowerCase(contra1)){
            return true;
        }
    }else{
        return false;
    }

}

function Contra1(){
    let contra1=document.getElementById("ContraseñaRegistrar1").value;
    let contraID=document.getElementById("ContraseñaRegistrar1");
    let contiene=false;
    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if(contra1.Contains(caracteresEspeciales[i])){contiene=true}
    }

    if(contra1!=toLowerCase(contra1) && contra1.length>=8 && contiene){
        contraID.classList.add("InputBien");
        contraID.classList.remove("InputMal");

    }else{
        contraID.classList.add("InputMal");
        contraID.classList.remove("InputBien");

    }
}