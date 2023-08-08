//PATRONES LOGICOS
//CONVINAR DISTINTAS VERIFICACIONES DE PATRONES

//NOT
String? apellido = "Gomez";

if (apellido is not null)
{
    Console.WriteLine(apellido.ToUpper());
}
//Console.WriteLine("Fin");

//AND
var temperatura = 38;
//patron de macheo, hay que cubrir todos los casos ya que switch no es exhaustivo
var mensaje = temperatura switch
{
    37 => "NO TIENES NINGUNA CONDICION",
    > 37 and <39 => "Tienes fiebre",
    >=39 and < 43=> "Debes ir al medico",
    >= 43 => "omae wa mou shindeiru",
    < 37 => "Puede que tengas baja el azucar"
};
Console.WriteLine(mensaje);

//OR
var hoy = DateTime.Today;
var estacion = hoy.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otoño",
    12 or 1 or 2 => "Invierno",
    //exception
    _=>throw new ApplicationException("Mes incorrecto")
};
Console.WriteLine(estacion);