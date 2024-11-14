using Concessionario;

Veiculo car = new Carro("Honda City", 2017, 70, 1.2, "SUV");

Veiculo cam = new Caminhao("Carreta", 1990, 170, 2.2, 2000);


double cons = car.CalcularConsumo(20);
Console.WriteLine(cons);
double consu = cam.CalcularConsumo(20);
Console.WriteLine(consu);

List<IVeiculos> lista = new List<IVeiculos> { car, cam };

Console.WriteLine("-=-=-=-=- Concessionaria -=-=-=-=-");
foreach (IVeiculos veiculos in lista)
{
    
    veiculos.ExibirDetalhes();
    veiculos.CalcularConsumo(15);
    //Console.WriteLine("");
}