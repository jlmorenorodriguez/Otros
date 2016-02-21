package com.example.joseluis.instrumentos_jlmr;

import android.content.Intent;
import android.content.SharedPreferences;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Contacto extends AppCompatActivity implements View.OnClickListener {

    private TextView txtDireccion, txtCall, txtPhone;
    private Button btnCall,btnWeb,btnMap;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_contacto);

        txtCall = (TextView) findViewById(R.id.txtCall);
        txtDireccion  = (TextView) findViewById(R.id.txtDireccion);
        txtPhone = (TextView) findViewById(R.id.txtPhone);

        btnCall = (Button) findViewById(R.id.btnCall);
        btnCall.setOnClickListener(this);

        btnWeb = (Button) findViewById(R.id.btnWeb);
        btnWeb.setOnClickListener(this);

        btnMap = (Button) findViewById(R.id.btnMap);
        btnMap.setOnClickListener(this);
    }

    public void onClick(View v) {

        switch (v.getId()){
            case R.id.btnCall:
                Intent i = new Intent(Intent.ACTION_DIAL);
                i.setData(Uri.parse("tel:" + txtPhone.getText()));
                startActivity(i);
                break;
            case R.id.btnWeb:
                startActivity(new Intent(Intent.ACTION_VIEW,
                        Uri.parse("http://www.google.com")));
                break;

            case R.id.btnMap:
                startActivity(new Intent(Intent.ACTION_VIEW,
                        Uri.parse("https://www.google.es/maps/place/Centro+Educativo+Altair/@37.376839,-5.9490906,17z/data=!3m1!4b1!4m2!3m1!1s0xd126ee40fe353ad:0xb6aa57c53acf7f1e")));
                break;
        }
    }
}
