package es.altair.Struts2Web.interceptors;

import java.util.Map;

import com.opensymphony.xwork2.ActionInvocation;
import com.opensymphony.xwork2.ActionSupport;
import com.opensymphony.xwork2.interceptor.Interceptor;

import es.altair.Struts2Web.bean.Usuario;

public class AuthenticationInterceptor implements Interceptor{

	public void destroy() {
		// TODO Auto-generated method stub
		
	}

	public void init() {
		// TODO Auto-generated method stub
		
	}

	public String intercept(ActionInvocation invocation) throws Exception {
		Map<String, Object> session = invocation.getInvocationContext().getSession();
		Usuario usu = (Usuario) session.get("usulogeado");
		if (usu == null)
			return ActionSupport.LOGIN;
		return invocation.invoke();
	}

}
