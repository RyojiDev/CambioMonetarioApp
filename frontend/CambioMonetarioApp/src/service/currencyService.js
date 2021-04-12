import api from '../config/api';

let currency;
export const getCurrency = async () => {
  try {
      const response = await api.get("/Parameters");
      //console.log(response);
      alert("to sendo executado")
      return  response.data.currencies
      
    
  } catch (error) {
      alert("ocorreu um erro ao pesquisar");
      console.log(error);
  }
}





