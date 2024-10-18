using Application.Abstractions;
using Application.RequestModels;
using Application.ResponseModels;
using Application.Services.IServices;
using AutoMapper;


namespace Application.Services
{
    public class RoomServices : IRoomServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RoomServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public Task<RoomResponse> Create(RoomRequest room)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int roomId)
        {
            //minh hoạ
            return true;
        }

        public async Task<List<RoomResponse>> GetAll()
        {
            var room = _mapper.Map<List<RoomResponse>>(await _unitOfWork.roomRepository.GetAllAsync());
            return room;
        }

        public async Task<RoomResponse> GetRoomById(int roomId)
        {
            var room = _mapper.Map<RoomResponse>(await _unitOfWork.roomRepository.GetByIdAsync(roomId));
            return room;
        }

        public Task<RoomResponse> Update(RoomRequest room)
        {
            throw new NotImplementedException();
        }
    }
}
