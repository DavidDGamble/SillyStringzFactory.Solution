using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine 
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Machine name cannot be empty!")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}