using System;
namespace CodeSmasher.Core {
    public abstract class ReviewAgent {
        public abstract void ReviewCode(string filePath, string code);
        public abstract string GetLanguage();
    }
}