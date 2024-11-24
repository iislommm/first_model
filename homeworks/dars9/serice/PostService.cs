﻿
using dars9.model;
using System.Net.WebSockets;
using System.Xml.Linq;

namespace _9dars.Servises;

public class PostServis
{
    private List<Post> posts;
    public PostServis()
    {
        var posts = new List<Post>();
    }

    public Post AddNewPost(Post post)
    {
        post.Id = Guid.NewGuid();
        posts.Add(post);
    
        return post;
    }
    public Post GetByPostId(Guid id)
    {
        foreach (var post in posts)
        {
            if (post.Id == id)
            {
                return post;
            }
        }

        return null;
    }

    public bool DeletePost(Guid id)
    {
        var postFromDB = GetByPostId(id);
        if (postFromDB is null)
        {
            return false;
        }
        posts.Remove(postFromDB);
        return true;
    }

    public bool UpdatePost(Post updatingPost)
    {
        var postFromDB = GetByPostId(updatingPost.Id);
        if (postFromDB is null)
        {
            return false;
        }
        var index = posts.IndexOf(updatingPost);
        posts[index] = updatingPost;

        return true;
    }

    public List<Post> GetAllPosts()
    {
        return posts;
    }

    public Post GetMostViewedPost()
    {
        Post mostViewedPost = null;
        var mostView = 0;
        foreach (var post in posts)
        {
            if (post.ViewerNames.Count > mostView)
            {
                mostView = post.ViewerNames.Count;
                mostViewedPost = post;
            }
        }

        return mostViewedPost;
    }
    public Post GetMostLikedPost()
    {
        Post mostLikedPost = null;
        var mostLike = 0;
        foreach (var post in posts)
        {
            if (post.Likes > mostLike)
            {
                mostLike = post.ViewerNames.Count;
                mostLikedPost = post;
            }
        }

        return mostLikedPost;
    }
    public Post GetMostCommentedPost()
    {
        Post mostCommentedPost = null;
        var mostComment = 0;
        foreach (var post in posts)
        {
            if (post.Comments.Count > mostComment)
            {
                mostComment = post.ViewerNames.Count;
                mostCommentedPost = post;
            }
        }

        return mostCommentedPost;
    }

    public List<Post> GetPostsByComment(string comment)
    {
        var ComnetdetPosts = new List<Post>();
        foreach (var post in posts)
        {
            var comments = post.Comments;
            if (comment.Contains(comment) is true)
            {
                ComnetdetPosts.Add(post);
            }
        }

        return ComnetdetPosts;
    }
    public bool AddComment (Guid postId, string comment)
    {
        var post = GetByPostId(postId);
        
        if (post == null)
        {
            return false;
        }

        post.Comments.Add(comment);
              

        return true;
    }
    public bool AddViewerNameToPost (Guid postId, string viewerName)
    {
        var post = GetByPostId(postId);
        if (post == null)
        {
            return false;
        }

        post.ViewerNames.Add(viewerName);
        return true;
    }
    public bool AddLike (Guid postId)
    {
        var post = GetByPostId(postId);
        if (post == null)
        {
            return false;
        }
        post.Likes++;
        return true;
    }

    internal object GetPostsByComment()
    {
        throw new NotImplementedException();
    }

    internal object AddLike()
    {
        throw new NotImplementedException();
    }

    internal object AddComment()
    {
        throw new NotImplementedException();
    }

    internal object AddViewerNameToPost()
    {
        throw new NotImplementedException();
    }
}