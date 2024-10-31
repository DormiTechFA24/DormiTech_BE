﻿using Application.Abstractions;
using Application.ResponseModels;
using Application.Services.IServices;
using AutoMapper;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class DisciplineTicketServices : IDisciplineTicketServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<List<AccDisciplineTicketDocument>> GetAll()
        {
            var room = _mapper.Map<List<RoomResponse>>(await _unitOfWork.roomRepository.GetAllAsync());
            return room;
        }

        public Task<AccDisciplineTicketDocument> GetByID(Guid id)
        {
            var room = _mapper.Map<RoomResponse>(await _unitOfWork.roomRepository.GetByIdAsync(roomId));
            return room;
        }
    }
}
