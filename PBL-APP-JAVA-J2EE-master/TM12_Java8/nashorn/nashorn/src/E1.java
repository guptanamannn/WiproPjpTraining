import javax.script.*;
import java.io.*;

public class E1 {
	public static void main(String args[])throws Exception{
		ScriptEngineManager manager = new ScriptEngineManager();
		ScriptEngine engine = manager.getEngineByName("nashorn");
		FileReader fr = new FileReader("Sample.js.txt");
		engine.eval(fr);
	}
}
