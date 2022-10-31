// See https://aka.ms/new-console-template for more information


using System.Text;

Console.WriteLine("Hello, World!");
var test = new string[] { "(A,B,C,D)", "(A-B,A-D,B-D,A-C)","(C)"};
var test2 = new string[] { "(X,Y,Z,Q)", "(X-Y,Y-Q,Y-Z)", "(Z,Y,Q)" };
var test3 = new string[] { "(X,Y,Z,Q)", "(X-Y,Y-Q,Y-Z)", "()" };

VertexCovering(test);
VertexCovering(test2);
VertexCovering(test3);


static string VertexCovering(string[] strArr)
{
    // code goes here 
    StringBuilder edgesLeftOut = new StringBuilder();
    var edges = strArr[1].Substring(1, strArr[1].Length - 2).Split(",");
    if (strArr[2].Length < 3) return strArr[1];
    var checkVertices = strArr[2].Substring(1, strArr[2].Length - 2);
    foreach (var item in edges)
    {
        if (checkVertices.Any(x => x == item[0]))
            continue;
        if (checkVertices.Any(x => x == item[2]))
            continue;
        edgesLeftOut.Append(item + ",");
    }
    if (edgesLeftOut.Length < 1)  return "yes";
    string ans =  "(" + edgesLeftOut.Remove(edgesLeftOut.Length-1, 1) + ")"; 
    return ans;
 }
