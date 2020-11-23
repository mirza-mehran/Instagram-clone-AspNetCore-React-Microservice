using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Instagram.Common.DTOs.Post;
using Instagram.Services.Post.Domain.Models;

namespace Instagram.Services.Post.Services
{
    public interface IUserPostService
    {
        Task<IEnumerable<UserPostReadDto>> GetAllPostsAsync();
        Task<UserPostReadDto> GetPostByIdAsync(Guid id);
        Task<IEnumerable<UserPostReadDto>> GetPostByUserIdAsync(Guid userId);
        Task<IEnumerable<UserPostReadDto>> GetUserLatestPostsAsync(Guid userId, DateTime lastModified);
        Task<UserPostReadDto> CreatePostAsync(Guid userId, UserPostCreateDto post);
        Task<UserPost> UpdatePostAsync(Guid id, UserPostUpdateDto post);
        Task<UserPost> DeletePostAsync(Guid id);   
        Task<PostLikeReadDto> CreatePostLikeAsync(Guid postId, Guid userId);
    }
}