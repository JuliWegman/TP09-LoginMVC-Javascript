const caracteresEspeciales = ['!','@','#','$','%','^','&','*','(',')','_','-','+','=','{','}','[',']',':',';','"',"'",'<','>',',','.','/','\\','|','?','~','`','¡','¿'];


function ChequearRegistro(){
    var contra1=null;
    var contra2=null;
    var telefono=null;
    let contiene=false;

    contra1=document.getElementById("ContraseñaRegistrar1").value;
    contra2=document.getElementById("ContraseñaRegistrar2").value;


    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if(contra1.includes(caracteresEspeciales[i])){contiene=true;}
    }

    if(contra1==contra2 && contra1.length>=8 && contiene && contra1!=contra1.toLowerCase()){
        return true;
        
    }else{
        return false;
    }

}

function Contra1(){
    let aviso=document.getElementById("avisoErrorRegistrarse");
    let contra1=document.getElementById("ContraseñaRegistrar1").value;
    let contraID1=document.getElementById("ContraseñaRegistrar1");
    let contiene=false;
    for (let i = 0; i < caracteresEspeciales.length; i++) {
        if(contra1.includes(caracteresEspeciales[i])){
            contiene=true;
        }
    }

    if(contra1.length<8){
        aviso.innerText="La contraseña debe ser de un mínimo de 8 caracteres";
        contraID1.classList.add("InputMal");
        contraID1.classList.remove("InputBien");
    }else if(!contiene){
        aviso.innerText="La contraseña debe tener al menos un caracter especial";
        contraID1.classList.add("InputMal");
        contraID1.classList.remove("InputBien");
    }else if(contra1==contra1.toLowerCase()){
        aviso.innerText="La contraseña debe contener al menos una mayúscula";
        contraID1.classList.add("InputMal");
        contraID1.classList.remove("InputBien");
    }else{
        aviso.innerText="";
        contraID1.classList.add("InputBien");
        contraID1.classList.remove("InputMal");
    }
}

function Contra2(){
    let contra1=document.getElementById("ContraseñaRegistrar1").value;
    let contra2=document.getElementById("ContraseñaRegistrar2").value;
    let contraID2=document.getElementById("ContraseñaRegistrar2");

    if(contra2===contra1){
        contraID2.classList.add("InputBien");
        contraID2.classList.remove("InputMal");

    }else{
        contraID2.classList.add("InputMal");
        contraID2.classList.remove("InputBien");

    }
}
function ChequearModificacion(){
    var contra1=null;
    var contra2=null;
    var telefono=null;
    let contiene=false;
    
    contra1=document.getElementById("ContraseñaModificar1").value;
    contra2=document.getElementById("ContraseñaModificar2").value;
    
    
     for (let i = 0; i < caracteresEspeciales.length; i++) {
        if(contra1.includes(caracteresEspeciales[i])){contiene=true;}
    }
    
    if(contra1==contra2 && contra1.length>=8 && contiene && contra1!=contra1.toLowerCase()){
        console.log("bien");
        return true;
        
    }else{
        console.log("mal");
        return false;
    }
}