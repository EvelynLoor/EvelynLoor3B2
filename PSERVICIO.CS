//•	Sobre el personal de servicio, hay que conocer a qué sección están asignados 
//(biblioteca, decanato, secretaría, ...). 
//•	Con respecto a los empleados, sean del tipo que sean, hay que saber su año de incorporación a
// la facultad y qué número de despacho tienen asignado. 

class PSERVICIO {

public string nombre;
public int cedula;
public int estadoCivil;
public int año;
public int despacho;
public string seccion;


public void PSERVICIO (string nombre, int cedula, int estadoCivil)

public void  EscribeNombre (string nom)
{
    this.nombre=nom;
}
public void EscribeCedula (int cedu)
{
    this.cedula=cedu;
}

public void EscribeCivil( int civil)
{
    this.estadoCivil=civil;
}

public void Escribeaño( int Año)
{

    this.año=Año;

}
public void Escribedespacho( int despa)
{
    this.despacho=despa;
}
public string EscribeSeccion( string secc)
{
    this.seccion=secc;
}
{

console.writeLine("Ecribe nombre del personal de servicio:" +ps3);
console.writeLine("Escribe cedula del personal de servicio:"+c3);
console.writeLine("Ecribe estado civil del personal de servicio;"+ec3);
console.writeLine("Escribe el año que se incorporo:"+a1);
console.writeLine("Escribe el número de despacho asignado:"+d1);
console.writeLine("Escribe la secccion asignada:"+s1);
}

return 0;

}