package com.example.joseluis.instrumentos_jlmr;

import android.app.ActionBar;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.support.v7.widget.Toolbar;
import android.view.ContextMenu;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

import org.w3c.dom.Text;

import java.util.ArrayList;

public class PaginaPrincipal extends AppCompatActivity {

    private static final int CODE1 = 1,CODEEDIT=2;
    private ListView listInstrumentos;
    private ArrayList<Instrumento> instrumentos = new ArrayList<>();
    private AdaptadorInstrumentos adaptador;
    private Toolbar toolbarPrincipal;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_pagina_principal);


        toolbarPrincipal = (Toolbar) findViewById(R.id.toolbarPrincipal);
        setSupportActionBar(toolbarPrincipal);
        toolbarPrincipal.setNavigationIcon(R.mipmap.icono_trombon);
        toolbarPrincipal.setSubtitle(R.string.subtitulo);

        listInstrumentos = (ListView) findViewById(R.id.listaInstrumentos);
        cargaInstrumentos();

        adaptador = new AdaptadorInstrumentos(this);

        listInstrumentos.setAdapter(adaptador);

        registerForContextMenu(listInstrumentos);


    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_accion, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {

        switch (item.getItemId()){
            case R.id.opcNew:
                Intent i = new Intent(PaginaPrincipal.this,AnyadirElemento.class);
                startActivityForResult(i, CODE1);

                break;
            case R.id.opcContact:

                Intent ii = new Intent(PaginaPrincipal.this,Contacto.class );
                startActivity(ii);


                break;
        }
        return true;
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {

        if(requestCode== CODE1){
            if (resultCode ==RESULT_OK ){
                Instrumento ins =
                        new Instrumento(instrumentos.size()+10,
                                data.getStringExtra("name"),
                                Integer.parseInt(data.getStringExtra("year")));
                instrumentos.add(ins);
                adaptador.notifyDataSetChanged();
            }
        }else if(requestCode==CODEEDIT){
            if(resultCode == RESULT_OK) {
                int id = data.getIntExtra("id", 0);

                Instrumento ins = new Instrumento(id,
                        data.getStringExtra("name"),
                        data.getIntExtra("year", 2000));


                int posicion = buscarProducto(id);

                int i = 0;
                for (Instrumento instrumento : instrumentos) {
                    if (instrumento.getId()==id) {
                        posicion = i;
                    }
                    i++;
                }
                if (posicion!=-1){
                    instrumentos.set(posicion, ins);
                    adaptador.notifyDataSetChanged();
                }

            }
            }
        }


    private int buscarProducto(int id) {
        int posicion = -1;

        int i = 0;
        for (Instrumento ins : instrumentos) {
            if (ins.getId() == id) {
                posicion = i;
            }
            i++;
        }

        return posicion;
    }
    @Override
    public void onCreateContextMenu(ContextMenu menu, View v, ContextMenu.ContextMenuInfo menuInfo) {
        super.onCreateContextMenu(menu, v, menuInfo);
        menu.setHeaderTitle(getResources().getString(R.string.menu));
        MenuInflater inflater = getMenuInflater();
        inflater.inflate(R.menu.menu_contextual, menu);
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {
        final AdapterView.AdapterContextMenuInfo info = (AdapterView.AdapterContextMenuInfo)item.getMenuInfo();

        switch (item.getItemId()){
            case R.id.opcEdit:

                Intent i = new Intent(PaginaPrincipal.this,EditarElemento.class);
                i.putExtra("id",instrumentos.get(info.position).getId());
                i.putExtra("nombre",instrumentos.get(info.position).getNombre());
                i.putExtra("año",instrumentos.get(info.position).getAnyo());
                startActivityForResult(i,CODEEDIT);
                break;
            case R.id.opcErase:
                LayoutInflater inflate = getLayoutInflater();
                View item2 = inflate.inflate(R.layout.header_alert, null);

                TextView textdel = (TextView)item2.findViewById(R.id.textdel);
                textdel.setText(getResources().getString(R.string.msgDel) + " " +
                        instrumentos.get(info.position).getNombre() + "?");

                AlertDialog.Builder builder = new AlertDialog.Builder(this);

                builder.setCustomTitle(item2);
                builder.setPositiveButton(getResources().getString(R.string.yes),new DialogInterface.OnClickListener() {
                           @Override
                           public void onClick(DialogInterface dialog, int which) {
                               instrumentos.remove(info.position);
                               adaptador.notifyDataSetChanged();
                           }
                       });
                builder.setNegativeButton(getResources().getString(R.string.no),
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                            }
                        });
                AlertDialog alerta = builder.create();
                alerta.show();
                break;
        }

        return true;
    }

    private void cargaInstrumentos(){
        instrumentos.add(new Instrumento(1,"Trombon Yamaha YSL-448G",2008));
        instrumentos.add(new Instrumento(2,"Trombon Jupiter 636RLO",2012));
        instrumentos.add(new Instrumento(3,"Trompeta Yamaha XENO ytr-8564",2001));
        instrumentos.add(new Instrumento(4,"Trompeta Bach Stradivarius 43ML",2003));
    }

    class AdaptadorInstrumentos extends ArrayAdapter {

        Activity context;

        public AdaptadorInstrumentos(Activity context) {
            super(context, R.layout.fila_instrumento, instrumentos);
            this.context = context;

        }

        @Override
        public View getView(int position, View convertView, ViewGroup parent) {
            //return super.getView(position, convertView, parent);

            View item = convertView;
            ViewHolder holder;

            if(item == null){
                LayoutInflater inflater = context.getLayoutInflater();
                item = inflater.inflate(R.layout.fila_instrumento,null);

                holder = new ViewHolder();

                holder.txtNameInstrument = (TextView)item.findViewById(R.id.txtNameInstrument);
                holder.txtYearInstrument = (TextView)item.findViewById(R.id.txtYearInstrument);

                item.setTag(holder);
            } else{
                holder = (ViewHolder)item.getTag();
            }
            holder.txtNameInstrument.setText(instrumentos.get(position).getNombre());
            holder.txtYearInstrument.setText(String.valueOf(instrumentos.get(position).getAnyo()));

            return item;
        }
    }

    static class ViewHolder {

        TextView txtNameInstrument;
        TextView txtYearInstrument;

    }

}
