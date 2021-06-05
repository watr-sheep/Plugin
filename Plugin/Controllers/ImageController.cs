using Plugin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Plugin.Controllers
{
    public class ImageController : ApiController
    {
        [HttpGet]
        public IEnumerable<Images> GetImageDetails()
        {
            Images img1 = new Images();
            Images img2 = new Images();
            Images img3 = new Images();

            List<Images> imgList = new List<Images>();

            img1.imageId = 1;
            img1.imageSize = 200;
            img1.imageBlur = 0;
            img1.imageRadius = 0;
            img1.effect1 = false;
            img1.effect2 = false;
            img1.effect3 = false;

            img2.imageId = 2;
            img2.imageSize = 200;
            img2.imageBlur = 0;
            img2.imageRadius = 0;
            img2.effect1 = false;
            img2.effect2 = false;
            img2.effect3 = false;

            img3.imageId = 3;
            img3.imageSize = 250;
            img3.imageBlur = 0;
            img3.imageRadius = 0;
            img3.effect1 = false;
            img3.effect2 = false;
            img3.effect3 = false;

            imgList.Add(img1);
            imgList.Add(img2);
            imgList.Add(img3);

            return imgList;
        }

        [HttpGet]
        public IEnumerable<Images> Get(int id)
        {
            Images img1 = new Images();
            Images img2 = new Images();
            Images img3 = new Images();

            List<Images> imgList = new List<Images>();

            if (id == 1)
            {
                img1.imageId = 1;
                img1.imageSize = 200;
                img1.imageBlur = 0;
                img1.imageRadius = 0;
                img1.effect1 = false;
                img1.effect2 = false;
                img1.effect3 = false;
                imgList.Add(img1);
            }
            else if (id == 2)
            {
                img2.imageId = 2;
                img2.imageSize = 200;
                img2.imageBlur = 0;
                img2.imageRadius = 0;
                img2.effect1 = false;
                img2.effect2 = false;
                img2.effect3 = false;
                imgList.Add(img2);

            }
            else
            {
                img3.imageId = 3;
                img3.imageSize = 200;
                img3.imageBlur = 0;
                img3.imageRadius = 0;
                img3.effect1 = false;
                img3.effect2 = false;
                img3.effect3 = false;
                imgList.Add(img3);
            }
            return imgList;
        }

        [HttpPost]
        public void PostImage([FromBody] Images cs)
        {
            //Steps to add new image to the database
        }

        [HttpPut]
        public void PutImage(int id, [FromBody] Images cs)
        {
            //steps to update existing image attributes
        }

        [HttpDelete]
        public void DeleteImage(int id)
        {
            //steps to delete an existing image
        }
    }
}