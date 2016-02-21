package com.example.joseluis.instrumentos_jlmr;

import android.content.Intent;
import android.content.SharedPreferences;
import android.support.design.widget.Snackbar;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.TextUtils;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class Login extends AppCompatActivity implements View.OnClickListener {


    private EditText edtUser;
    private EditText edtPassword;
    private Button btnSave;

    private SharedPreferences sp;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login);

        edtUser = (EditText)findViewById(R.id.edtUser);
        edtPassword = (EditText)findViewById(R.id.edtPassword);
        btnSave = (Button)findViewById(R.id.btnSave);
        btnSave.setOnClickListener(this);


        sp = getSharedPreferences("datos",MODE_PRIVATE);

        if (sp.contains("user")){
//            Intent i = new Intent(Main2Activity.this ,Main3Activity.class );
//            startActivity(i);
//            finish();
            edtUser.setText(sp.getString("user",""));
        }

    }


    @Override
    public void onClick(View v) {

        switch (v.getId()){
            case R.id.btnSave:

                if(TextUtils.isEmpty(edtUser.getText().toString())||TextUtils.isEmpty(edtPassword.getText().toString())) {
                    Snackbar.make(v,R.string.mensajeLogin,Snackbar.LENGTH_SHORT).show();
                    break;
                }
                    SharedPreferences.Editor editor = sp.edit();
                    editor.putString("user", edtUser.getText().toString());
                    editor.putString("password", edtPassword.getText().toString());
                    editor.commit();
                    edtUser.setText("");
                    edtPassword.setText("");

                    Intent i = new Intent(Login.this, PaginaPrincipal.class);
                    startActivity(i);
                    finish();


                break;
        }
    }
}
