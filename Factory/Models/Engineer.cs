using System.ComponentModel.DataAnnotations;

namespace Factory.Models 
{
  public class Engineer 
  {
    public int EngineerId { get; set; }
    [Required(ErrorMessage = "Engineer name cannot be empty!")]
    public string Name { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}