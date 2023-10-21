using Microsoft.AspNetCore.Mvc;

[ApiController]
public class ClienteController : ControllerBase{

    public Clientes[] Cliente = new Clientes []{

        new Clientes{Nombre_Cliente="Juan", Apellido_Cliente="Perez",edad=22, Rut="18293129-2"},
        new Clientes{Nombre_Cliente="Roberto", Apellido_Cliente="Martinez", edad=19,Rut="14993432-3"},
        new Clientes{Nombre_Cliente="Felipe", Apellido_Cliente="Correa", edad=30,Rut="17238543-2"},

    };

    public Empresa[] Empresas = new Empresa[]{
        new Empresa{id=1, Nombre_Empresa="Luis lt", Rut_Empresa="78328432-2",Giro_Empresa="Comida rapida"},
        new Empresa{id=2, Nombre_Empresa="Juan SA", Rut_Empresa="90436532-3",Giro_Empresa="Juegos electronicos"},
        new Empresa{id=3, Nombre_Empresa="Mecanica SA", Rut_Empresa="493485473-3",Giro_Empresa="Electronica"},
    };
    // ingresamos datos a nuestras tablas
        [HttpGet]
        [Route("Empresa")]
    
    public IActionResult ListarEmpresas(){
        try{
            if(Empresas != null){
                for(int i=0; i < Empresas.Length; i++ ){
                    Console.WriteLine(Empresas[i]);
                }
                return StatusCode(200,Empresas);
            }else{
                return StatusCode(404, "No se pudo actualizar");
            }
        }catch(Exception ex){
            Console.WriteLine("El sistema no ha permitido");
        }
        return StatusCode(401,"No se pudo realizar su petucion");
    }
    //Realizamos la ruta get para listar la empresa ademas realizamos un if para verificar
    //que el id no es nulo y un for para obtener a todos en la lista    

    [HttpGet]
    [Route("Empresa/{id}")]

    public IActionResult ListarAlumnos(int id){
        try{
            if(id > 0 && id <= Empresas.Length){
                return StatusCode(200,Empresas[id-1]);
            }else{
                return StatusCode(401,"No se ha encontrado el alumno");
            }
        }catch(Exception ex){
            return StatusCode(500,"Error interno");
        }
    }
    //Realizamos la ruta get y realizamos uun if para darle los parametros de cual los cuales si 
    //son validos trae a la empresa

    [HttpPost]
    [Route("Persona")]

    public IActionResult CrearPersonas([FromBody] Empresa Empresas){
        try{
            if(Empresas != null){
                Console.WriteLine($"Empresa creada - id: {Empresas.id}, Nombre_Empresa: {Empresas.Nombre_Empresa}, Rut_Empresa: {Empresas.Rut_Empresa}, Giro_Empresa:{Empresas.Giro_Empresa}");
                return StatusCode(201, Empresas);
            }else{
                Console.WriteLine("No ha podido crear");
                return StatusCode(401);
            }
        }catch(Exception ex){
            return StatusCode(500,"Error sistema");
        }

}
    //Realizamos la ruta port y realizamos uun if para ver que no sea nulo y generamos una
    // nueva empresa
    [HttpPut]
    [Route ("Empresa/{id}")]

    public IActionResult Editar(int id, [FromBody] Empresa empresa){

        try{
            if(id > 0 && id == empresa.id){
            Empresas[id-1].Nombre_Empresa=empresa.Nombre_Empresa;
            Empresas[id-1].Rut_Empresa=empresa.Rut_Empresa;
            Empresas[id-1].Giro_Empresa=empresa.Giro_Empresa;
                return StatusCode(200, Empresas);
            }else{
                return StatusCode(404,"Prueba otra vez");
            }
        }catch(Exception ex){
            return StatusCode(500, "Error del servidor");
        }
    }
    //Realizamos la ruta put y realizamos uun if para darle los parametros que si es valido
    //podemos modicar a una de las empresas
    [HttpDelete]
    [Route("Empresa/{id}")]

    public IActionResult Eliminar(int id){
        try{
            if(id >0 && id <= Empresas.Length){
                Empresas[id-1] = null;
                return StatusCode(200,"eliminado exitosamente");
            }else{
                return StatusCode(404,"No se ha podido eliminar");
            }
        }catch(Exception ex){
            return StatusCode(500,"Error sistema");
        }
    }     
    //Realizamos la ruta delete y usamos if para verificar los parametros si el parametro es valido
    //elimina el regiistro
    
}


