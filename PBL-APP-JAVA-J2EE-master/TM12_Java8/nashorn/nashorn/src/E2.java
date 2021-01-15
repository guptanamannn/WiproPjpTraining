import javax.script.*;
import java.io.*;

public class E2{
	public static void main(String args[])throws Exception{
		ScriptEngineManager manager = new ScriptEngineManager();
		ScriptEngine engine = manager.getEngineByName("nashorn");
		FileReader fr = new FileReader("Demo.js.txt");
		engine.eval(fr);
		Invocable invocable = (Invocable)engine;
		invocable.invokeFunction("v", 9);
	}
}
