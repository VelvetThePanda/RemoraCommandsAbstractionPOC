using System.Text;

namespace RemoraCommandsAbstractionPOC;

public class CodeWriter : IDisposable
{
    private readonly StringBuilder _stringBuilder = new();
    private readonly CodeWriter? _parent;
    private readonly int _indent = 0;

    public CodeWriter() { }
    
    private CodeWriter(CodeWriter parent)
    {
        _parent = parent;
        _indent = parent._indent + 1;
    }
    
    public CodeWriter Append(string text)
    {
        _stringBuilder.Append(text);
        
        return this;
    }
    
    public CodeWriter Append(char text)
    {
        _stringBuilder.Append(text);
        
        return this;
    }

    public CodeWriter AppendLine(char text)
    {
        _stringBuilder.AppendLine(text.ToString());

        return this;
    }
    
    public CodeWriter AppendLine(string text)
    {
        _stringBuilder.AppendLine(GetIndent() + text);
        
        return this;
    }

    public CodeWriter Flush()
    {
        _parent?.AppendLine(ToString());
        _stringBuilder.Clear();

        return this;
    }
    
    public CodeWriter CreateChildWriter() => new(this);

    public override string ToString() => _stringBuilder.ToString();

    private string GetIndent() => new('\t', _indent);

    public void Dispose() => Flush();


}