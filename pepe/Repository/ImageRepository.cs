using System;
using pepe.models;
namespace pepe.Repository
{
	public interface ImageRepository
	{
        ImageClass GetImage(string? Id);
        ImageClass GetRandomImage();
        ImageClass AddImage(ImageClass image);
        ImageClass UpdateImage(ImageClass image);
        ImageClass DeleteImage(string? Id);
	}
}

/* public class ImageRespositoryClass {

         ImageClass GetImage(string? Id);
        ImageClass GetRandomImage();
        ImageClass AddImage(ImageClass image);
        ImageClass UpdateImage(ImageClass image);
        ImageClass DeleteImage(string? Id);
}
 */