using SolidTest;
using SolidTest.responsabilidadUnica;
using SolidTest.segregacionInterfaces;
using SolidTest.sustitucionLiskov;
/*
String nombreArchivo1 = "C:\\Users\\Gutie\\Desktop\\idp.txt";
String nombreArchivo2 = "C:\\Users\\Gutie\\Desktop\\idpBin.bin";
Archivo texto = new ArchivoTexto(nombreArchivo1);
Archivo binario = new ArchivoBinario(nombreArchivo2);
List<String> lista = new List<string>();
lista.Add("hola");
lista.Add("que");
lista.Add("tal");
lista.Add("como");
lista.Add("estas");

Escritor escritor1 = new Escritor(texto);
escritor1.escribirArchivoConLista(lista);

Usuario u1 = Usuario.registrarse("roma3210","luro 3000");
Usuario u2 = Usuario.registrarse("mana312","independencia 1200");
Usuario u3 = Usuario.registrarse("je213","colon 1600");

MostrarUsuario.mostrar(u1);
MostrarUsuario.mostrar(u2);
MostrarUsuario.mostrar(u3);

Soldado s1 = new Soldado("pablo",1000,10,20,50);
Medico m2 = new Medico("pepe",500,0,10,200);

s1.atacar(m2);
Console.WriteLine(m2.Salud);
s1.atacar(m2);
Console.WriteLine(m2.Salud);
m2.curar(m2);
Console.WriteLine(m2.Salud);
*/
Adulto p1 = new Adulto("pepe",30,3333333);
Menor m1 = new Menor("nene",10,p1);

p1.pagar();
m1.pagar();