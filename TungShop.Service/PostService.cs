using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TungShop.Model.Model;
using TungShop.Data.Repositories;
using TungShop.Model.Infrastructure;

namespace TungShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int ID);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totolRow);
        Post GetbyID(int ID);
        IEnumerable<Post> GetAllByPaging(int page, int pageSize, out int totolRow);
        void SaveChanges();

    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService(IPostRepository postRepository,IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Delete(int ID)
        {
            _postRepository.Delete(ID);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByPaging(int page, int pageSize, out int totolRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totolRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status,out totolRow,page,pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totolRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status,out totolRow,page,pageSize);
        }

        public Post GetbyID(int ID)
        {
            return _postRepository.GetSingleById(ID);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
