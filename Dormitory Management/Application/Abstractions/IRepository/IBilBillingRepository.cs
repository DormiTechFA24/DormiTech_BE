﻿using Domain.Model;

namespace Application.Abstractions.IRepository;

public interface IBilBillingRepository
{
    Task<IEnumerable<BilBilling>> Get();

    Task<IEnumerable<BilBilling>> Search(
        Guid? student);

    void Create(BilBilling bilBilling);
    void Update(BilBilling bilBilling);
}