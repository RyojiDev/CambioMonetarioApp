import React from 'react';
import { View, Text, StyleSheet, TextInput, TouchableOpacity } from 'react-native';
import Header from './Components/Header';

const App = () =>{

  const enviar = () =>{
    alert("enviar valores")
  }
  return(
    <View style={estilo.container}>
    <Header></Header>
      <Text style={estilo.textInput}>
        Qual valor você deseja fazer deposito?
      </Text>
      <TextInput stye={estilo.inputForm}></TextInput>
      <TextInput style={estilo.inputForm}>
      </TextInput>
      <TouchableOpacity style={estilo.submitForm} onPress={enviar}>
        <Text>
          Converter
        </Text>
      </TouchableOpacity>
    </View>
  )
}

const estilo = StyleSheet.create({
  container:{
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'green'
  },
  textInput:{
    fontSize: 14,
    marginBottom: 20
  },
  inputForm: {
    backgroundColor: '#fff',
    width: '90%',
    marginBottom: 15,
    color: '#222',
    fontSize: 18,
    borderRadius: 8,
    padding: 10
  },
  submitForm: {
    backgroundColor: '#ebb105',
    width: '80%',
    height: 45,
    alignItems: 'center',
    justifyContent: 'center',
    borderRadius: 8
  },textSaldo: {
    color: '#fff',
    flexDirection: 'column-reverse'
  }

})

export default App;