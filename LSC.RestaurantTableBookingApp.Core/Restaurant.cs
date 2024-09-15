using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LSC.RestaurantTableBookingApp.Core;

public partial class Restaurant
{
    //Id will be automatically considered as Primary Key by EF. If name (Id) is different then add attribute [Key].
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(200)]
    public string Address { get; set; } = null!;

    
    [MaxLength(20)]
    public string? Phone { get; set; }

    
    [MaxLength(100)]
    public string? Email { get; set; }

    
    [MaxLength(500)]
    public string? ImageUrl { get; set; }

    /*
     * As Restaurant Table has a child table Restaurant Branch i.e PK of Restaurant is FK of Restaurant Branch.
     * So, In Parent Class, it is Virtual ICollection and in Child Class it is virtual
     */
    public virtual ICollection<RestaurantBranch> RestaurantBranches { get; set; } = new List<RestaurantBranch>();
}
