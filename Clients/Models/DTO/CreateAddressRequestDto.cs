﻿using Clients.Models.Domain;

namespace Clients.Models.DTO;

public class CreateAddressRequestDto
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string PostalCode { get; set; }
    public string Neighborhood { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

}
