var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews(); /*Default olarak gelmez controller ve viewi birlikte calistirmak istiyorsak bu satiri kullanmaliyiz*/

var app = builder.Build();



 
app.UseStaticFiles(); // bunu yazarak wwwrootu dýþarýya açmýþ oluyoruz. yani wwwroot klasorunun icindeki ogelere erisim saglamak icin bu kod zorunlu. 
app.UseRouting(); //ustteki komutla birlikte calisir. sonradan bir middleware ekledigimizde sirasinin karismamasi icin 


//BURADAKI KISIM YERINE CONTROLLERDAKI SEMA AKTIF OLUR
//app.MapGet("/", () => "Hello World!");
// {controller=Home}/{action=Index}/{id?} BU SEMAYI KULLANMIS OLUYORUZ

//app.MapDefaultControllerRoute(); BU DA KULLANILABILIR OPSIYONEL

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
