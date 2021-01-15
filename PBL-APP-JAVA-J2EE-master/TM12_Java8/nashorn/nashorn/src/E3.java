import javax.script.*;
import java.io.*;
public class E3 {
	public static void main(String args[])throws Exception {
		ScriptEngineManager manager = new ScriptEngineManager();
		ScriptEngine engine = manager.getEngineByName("nashorn");
		FileReader fr = new FileReader("HashMap.js.txt");
		engine.eval(fr);
	}
}
