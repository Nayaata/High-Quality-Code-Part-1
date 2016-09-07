namespace CohesionAndCoupling
{
    public static class FileUtils
    {
        /// <summary>
        /// Get file extension of given string file name.
        /// </summary>
        /// <param name="fileName">String fileName is the input parameter.</param>
        /// <returns>Extension as string, otherwise empty string.</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        /// <summary>
        ///  Get file name without extension of given string file name.
        /// </summary>
        /// <param name="fileName">String fileName is the input parameter.</param>
        /// <returns>File name without extension as string.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");

            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            
            return extension;
        }
    }
}
