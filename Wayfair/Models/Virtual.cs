using System;
using Wayfair.Interfaces;

namespace Wayfair.Models
{
  public class Virtual<T> : IRepoItem<T>
  {
    public T Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

  


  }
}