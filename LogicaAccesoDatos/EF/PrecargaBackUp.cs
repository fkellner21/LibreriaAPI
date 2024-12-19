

using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Win32;
using System;

namespace LogicaAccesoDatos.EF
{
    internal class PrecargaBackUp
    {

        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 1, "fran@mail.com", "Asd123!", "a569dcad190122e7a19036dd7740a4e238541c26a8f23fcdf015179c3d9ce70a", "franisco", "kellner", "Encargado", true });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 2, "messi@mail.com", "Asd123!.", "2785dc6aaa6c1b4b3a968bc1d6a0fd89ac7b13f331b5f2ef65716cd586b03b6e", "Lionel", "Messi", "Encargado", false });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 3, "suarez@yahoo.com", "Aqwe123.", "7f0782a1031d42b27853da9c8fe4ac45b9a4142514864fa410d581338de47103", "Luis", "kellner", "Encargado", false });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 4, "pepe@hotmail.com", "lkj34!?L", "bab6f0ca2329330647bc23f8866e505f9d578e92c470d162d26504993a3194f6", "Jose", "Araujo", "Administrador", true });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 5, "lolo@mail.com", "je.U239", "439342ed8743a61b72ea85d5e970de366986920a2b630fc8130d69ab27f197ef", "Lorenzo", "Lopez", "Administrador", false });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 6, "a@gmail.com", "Qwe1?-", "f9a11ee5c15300a6748e10cea039b9a14d8f7d86e5ef40159e055347ffbacd55", "Anton", "Perez", "Administrador", true });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 7, "juan@yahoo.com", "Alkjs34!", "ff9b5ee47dcaf7ab93debfca926830124763019e6ea241b74302d5e43b72a0ee", "Analia", "Repeto", "Administrador", false });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 8, "duidas@mail.com", "hi@!!3A", "885282956400319b3e91c67753bc90c30c6604745b26c92131a720aa7290129e", "Dj", "Sanata", "Administrador", false });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 9, "nuevo@libreria.com", "KIje23!p", "762d4e3be93f7182f1f754959b8b394696ad901841551559a6d89bd2cbd9a309", "Danilo", "kellner", "Administrador", false });
        //migrationBuilder.InsertData("Usuarios", new[] { "Id", "Email", "Password", "PasswordHash", "Nombre", "Apellido", "Discriminator", "ModificaUsuario" }, new object[] { 10, "jefe@mail.com", "1ElJefe!", "d2e7c664ec934d5c10f5b83018a859e0fb8b6ca0f07260b198d21938ae0b885f", "Yamandu", "Gonzalez", "Administrador", true });

        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 1, "Lapicera", "Para escribir", "1112223334445", 52.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 2, "Libreta", "Para tomar apuntes", "1230987654345", 68.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 3, "Lapiz", "Intensidad Hb", "1234567890987", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 4, "Cuadernola", "Tapa dura", "0987654321234", 110.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 5, "Compas", "Punta super resistente", "0098766543212", 94.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 6, "Goma de borrar", "Goma de pan", "1123399876543", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 7, "Marcador", "Indeleble para marcar", "0098765432125", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 8, "Marcador", "Para pizarra", "0987654321298", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 9, "Sacapunta", "Metalico, super resistente", "9878898767123", 41.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 10, "Cuaderno", "120 hojas", "7778882348877", 89.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 11, "Regla", "30 cm", "2345678901234", 25.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 12, "Cinta adhesiva", "Transparente", "3334445556667", 18.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 13, "Tijeras", "De acero inoxidable", "7654321987654", 30.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 14, "Resaltador", "Fluorescente", "8765432109876", 22.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 15, "Folder", "Para documentos", "6543210987654", 45.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 16, "Calculadora", "De bolsillo", "9876543210123", 75.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 17, "Pegamento", "En barra", "5678901234567", 15.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 18, "Pizarra blanca", "Magnética", "2345678909876", 120.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 19, "Borrador", "Para pizarrón", "6543210987654", 28.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 20, "Cartuchera", "Para útiles", "8901234567890", 40.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 21, "Lápices de colores", "12 unidades", "3456789012345", 32.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 22, "Corrector", "Líquido", "7890123456789", 20.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 23, "Papel blanco", "A4, paquete de 100 hojas", "0123456789012", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 24, "Separadores", "Para carpetas", "5432109876543", 14.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 25, "Estuche", "Para lápices", "9012345678901", 18.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 26, "Agenda", "Anual", "6789012345678", 60.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 27, "Carpeta", "De argollas", "3456789012345", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 28, "Marcadores de página", "Con colores", "7890123456789", 8.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 29, "Bolígrafos", "Pack de 10 unidades", "2345678901234", 42.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 30, "Papel milimetrado", "Cuadriculado", "5678901234567", 55.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 31, "Grapadora", "De escritorio", "8901234567890", 38.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 32, "Cinta correctora", "En rollo", "1234567890123", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 33, "Plumones", "Para pizarra blanca", "4567890123456", 28.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 34, "Adhesivo removible", "Para notas", "7890123456789", 10.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 35, "Clips", "Metálicos", "2345678901234", 5.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 36, "Carpeta colgante", "Para archivos", "5678901234567", 22.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 37, "Bolsa de papel", "Para regalo", "8901234567890", 8.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 38, "Cutter", "Con cuchillas reemplazables", "1234567890123", 18.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 39, "Rotulador", "Permanente", "4567890123456", 22.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 40, "Cuaderno de dibujo", "Hojas lisas", "7890123456789", 65.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 41, "Portaminas", "Con recarga", "2345678901234", 40.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 42, "Cinta doble cara", "Para manualidades", "5678901234567", 14.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 43, "Caja organizadora", "Para útiles", "8901234567890", 70.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 44, "Tabla de corte", "Autorreparable", "1234567890123", 90.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 45, "Papel kraft", "Rollo", "4567890123456", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 46, "Carpetas con broche", "Pack de 10", "7890123456789", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 47, "Goma EVA", "Plancha A4", "2345678901234", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 48, "Perforadora", "De dos agujeros", "5678901234567", 38.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 49, "Ganchos", "Para carpetas colgantes", "8901234567890", 10.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 50, "Lápiz corrector", "Tipo bolígrafo", "1234567890123", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 51, "Block de notas", "Tamaño A5", "4567890123456", 18.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 52, "Cuaderno espiral", "100 hojas", "7890123456789", 45.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 53, "Punzón", "Para manualidades", "2345678901234", 10.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 54, "Etiqueta adhesiva", "Paquete de 50", "5678901234567", 15.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 55, "Papel celofán", "Transparente", "8901234567890", 25.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 56, "Bolsa de plástico", "Con cierre", "1234567890123", 8.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 57, "Cuchilla giratoria", "Para cortar", "4567890123456", 30.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 58, "Pinceles", "Pack de 5", "7890123456789", 40.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 59, "Portafolio", "Tamaño carta", "2345678901234", 85.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 60, "Lupa", "De mano", "5678901234567", 20.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 61, "Tijeras de precisión", "Para manualidades", "8901234567890", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 62, "Cuaderno profesional", "80 hojas", "1234567890123", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 63, "Goma laca", "Para acabado", "4567890123456", 22.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 64, "Papel para acuarela", "200 g/m²", "7890123456789", 65.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 65, "Lápiz mecánico", "Con minas 0.5mm", "2345678901234", 28.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 66, "Minas para lápiz mecánico", "0.5mm, paquete de 20", "5678901234567", 10.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 67, "Bloc de bocetos", "Tamaño A4", "8901234567890", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 68, "Papel mantequilla", "Tamaño carta", "1234567890123", 15.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 69, "Cinta de enmascarar", "Rollo de 20m", "4567890123456", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 70, "Escuadra", "Plástica, 45°", "7890123456789", 22.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 71, "Regla T", "Para dibujo técnico", "2345678901234", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 72, "Transportador", "Plástico, 180°", "5678901234567", 15.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 73, "Papel fotográfico", "Paquete de 20 hojas", "8901234567890", 45.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 74, "Resma de papel", "500 hojas, tamaño carta", "1234567890123", 80.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 75, "Láminas de colores", "Paquete de 10", "4567890123456", 20.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 76, "Bolsa plástica con cierre", "Paquete de 50", "7890123456789", 18.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 77, "Paleta de pintor", "Para mezclar colores", "2345678901234", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 78, "Set de geometría", "Regla, escuadra y compás", "5678901234567", 30.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 79, "Cinta métrica", "Retráctil, 5m", "8901234567890", 25.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 80, "Carpeta de presentación", "Con fundas", "1234567890123", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 81, "Goma arábiga", "Para manualidades", "4567890123456", 18.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 82, "Cinta adhesiva de papel", "Rollo de 30m", "7890123456789", 22.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 83, "Caja de archivo", "Para documentos", "2345678901234", 28.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 84, "Cartulina", "Paquete de 20", "5678901234567", 24.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 85, "Papel lustrillo", "Paquete de 10", "8901234567890", 15.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 86, "Papel crepé", "Rollo de 2m", "1234567890123", 10.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 87, "Afilador de lápices", "Manual, de mano", "4567890123456", 25.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 88, "Tabla de madera", "Para dibujo", "7890123456789", 45.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 89, "Portafolios expandible", "Con 12 divisiones", "2345678901234", 55.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 90, "Set de lápices", "Grafito, 6 unidades", "5678901234567", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 91, "Tiza", "Paquete de 50", "8901234567890", 20.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 92, "Alfombrilla de corte", "Para manualidades", "1234567890123", 25.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 93, "Libro de dibujo", "Para colorear", "4567890123456", 30.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 94, "Portadocumentos", "Transparente", "7890123456789", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 95, "Separadores de colores", "Para carpetas", "2345678901234", 15.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 96, "Mochila escolar", "Para niños", "5678901234567", 120.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 97, "Tablón de anuncios", "Con corcho", "8901234567890", 80.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 98, "Gráficas", "Pack de 5 hojas", "1234567890123", 20.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 99, "Pegatinas", "Decorativas", "4567890123456", 8.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 100, "Mapa", "Del mundo", "7890123456789", 25.00 });

        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 1, "Compra", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 2, "Venta", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 3, "Rotura", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 4, "Pérdida", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 5, "Ingreso de tienda", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 6, "Devolución", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 7, "Donación recibida", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 8, "Donación realizada", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 9, "Ajuste a mas por inventario", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 10, "Ajuste a menos por inventario", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 11, "Transferencia recibida", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 12, "Transferencia enviada", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 13, "Devolución de cliente", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 14, "Devolución a proveedor", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 15, "Corrección, aumento por error", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 16, "Corrección, disminuye por error", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 17, "Reembolso recibido", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 18, "Reembolso realizado", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 19, "Promoción", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 20, "Regalo", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 21, "Producción terminada", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 22, "Materia prima usada", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 23, "Aumento por cambio de estado", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 24, "Disminucion por cambio de estado", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 25, "Aumento por rotación de stock", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 26, "Disminucion por rotación de stock", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 27, "Pedido especial recibido", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 28, "Pedido especial enviado", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 29, "Ingreso por reciclaje", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 30, "Salida por reciclaje", false });


        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 1, new DateTime(2023, 1, 1, 10, 0, 0), 1, 1, 1, 20 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 2, new DateTime(2023, 1, 2, 11, 0, 0), 2, 2, 2, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 3, new DateTime(2023, 1, 3, 12, 0, 0), 3, 3, 3, 30 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 4, new DateTime(2023, 1, 4, 13, 0, 0), 4, 4, 4, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 5, new DateTime(2023, 1, 5, 14, 0, 0), 5, 5, 5, 40 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 6, new DateTime(2023, 1, 6, 15, 0, 0), 6, 6, 6, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 7, new DateTime(2023, 1, 7, 16, 0, 0), 7, 1, 1, 10 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 8, new DateTime(2023, 1, 8, 17, 0, 0), 8, 2, 2, 20 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 9, new DateTime(2023, 1, 9, 18, 0, 0), 9, 3, 3, 5 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 10, new DateTime(2024, 1, 10, 19, 0, 0), 5, 5, 4, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 11, new DateTime(2024, 1, 11, 20, 0, 0), 11, 5, 5, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 12, new DateTime(2024, 1, 12, 21, 0, 0), 12, 6, 6, 50 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 13, new DateTime(2024, 1, 13, 22, 0, 0), 5, 5, 1, 35 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 14, new DateTime(2024, 1, 14, 23, 0, 0), 14, 2, 2, 45 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 15, new DateTime(2024, 1, 15, 23, 0, 0), 15, 3, 3, 60 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 16, new DateTime(2024, 1, 16, 10, 0, 0), 5, 5, 4, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 17, new DateTime(2024, 1, 17, 11, 0, 0), 17, 5, 5, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 18, new DateTime(2024, 1, 18, 12, 0, 0), 18, 6, 6, 40 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 19, new DateTime(2024, 1, 19, 13, 0, 0), 19, 1, 1, 10 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 20, new DateTime(2024, 1, 20, 14, 0, 0), 20, 2, 2, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 21, new DateTime(2024, 1, 21, 15, 0, 0), 21, 3, 3, 20 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 22, new DateTime(2024, 1, 22, 16, 0, 0), 22, 4, 4, 30 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 23, new DateTime(2024, 1, 23, 17, 0, 0), 5, 5, 5, 35 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 24, new DateTime(2024, 1, 24, 18, 0, 0), 24, 6, 6, 50 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 25, new DateTime(2024, 1, 25, 19, 0, 0), 25, 1, 1, 20 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 26, new DateTime(2024, 1, 26, 20, 0, 0), 26, 2, 2, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 27, new DateTime(2024, 1, 27, 21, 0, 0), 27, 3, 3, 30 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 28, new DateTime(2024, 1, 28, 22, 0, 0), 28, 4, 4, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 29, new DateTime(2024, 1, 29, 23, 0, 0), 29, 5, 5, 40 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 30, new DateTime(2024, 1, 30, 23, 0, 0), 30, 6, 6, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 31, new DateTime(2024, 1, 31, 10, 0, 0), 5, 5, 1, 20 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 32, new DateTime(2024, 2, 1, 11, 0, 0), 2, 2, 2, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 33, new DateTime(2024, 2, 2, 12, 0, 0), 3, 3, 3, 30 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 34, new DateTime(2024, 2, 3, 13, 0, 0), 4, 4, 4, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 35, new DateTime(2024, 1, 31, 10, 0, 0), 5, 5, 5, 40 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 36, new DateTime(2024, 2, 5, 15, 0, 0), 6, 6, 6, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 37, new DateTime(2024, 2, 6, 16, 0, 0), 7, 1, 1, 10 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 38, new DateTime(2024, 2, 7, 17, 0, 0), 8, 2, 2, 20 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 39, new DateTime(2024, 2, 8, 18, 0, 0), 9, 3, 3, 5 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 40, new DateTime(2024, 2, 9, 19, 0, 0), 10, 4, 4, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 41, new DateTime(2024, 2, 10, 20, 0, 0), 11, 5, 5, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 42, new DateTime(2024, 2, 11, 21, 0, 0), 12, 6, 6, 50 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 43, new DateTime(2024, 2, 12, 22, 0, 0), 13, 1, 1, 35 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 44, new DateTime(2024, 2, 13, 23, 0, 0), 14, 2, 2, 45 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 45, new DateTime(2024, 2, 14, 23, 0, 0), 15, 3, 3, 60 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 46, new DateTime(2024, 2, 15, 10, 0, 0), 16, 4, 4, 15 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 47, new DateTime(2024, 2, 16, 11, 0, 0), 17, 5, 5, 25 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 48, new DateTime(2024, 2, 17, 12, 0, 0), 18, 6, 6, 40 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 49, new DateTime(2024, 2, 18, 13, 0, 0), 19, 1, 1, 10 });
        //migrationBuilder.InsertData("MovimientosDeStock", new[] { "Id", "fecha", "articuloId", "tipoId", "ejecutorId", "cantidad" }, new object[] { 50, new DateTime(2024, 2, 19, 14, 0, 0), 20, 2, 2, 25 });




        //NO USAR, DE ACA PARA ABAJO SON LOS VIEJOS

        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 1, "Lapicera", "Para escribir", "1112223334445", 52.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 2, "Libreta", "Para tomar apuntes", "1230987654345", 68.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 3, "Lapiz", "Intensidad Hb", "1234567890987", 35.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 4, "Cuadernola", "Tapa dura", "0987654321234", 110.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 5, "Compas", "Punta super resistente", "0098766543212", 94.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 6, "Goma de borrar", "Goma de pan", "1123399876543", 12.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 7, "Marcador", "Indeleble para marcar", "0098765432125", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 8, "Marcador", "Para pizarra", "0987654321298", 50.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 9, "Sacapunta", "Metalico, super resistente", "9878898767123", 41.00 });
        //migrationBuilder.InsertData("Articulos", new[] { "Id", "Nombre", "Descripcion", "Codigo", "PrecioDeVenta" }, new object[] { 10, "Cuaderno", "120 hojas", "7778882348877", 89.00 });


        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 1, "Compra", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 2, "Venta", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 3, "Rotura", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 4, "Perdida", false });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 5, "Ingreso de tienda", true });
        //migrationBuilder.InsertData("TiposDeMovimiento", new[] { "Id", "Nombre", "aumentaStock" }, new object[] { 6, "Devolucion", true });

    }
}
