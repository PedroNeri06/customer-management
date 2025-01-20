import './App.css';
import Axios from 'axios';
const GetAxios = await Axios.get('https://jsonplaceholder.typicode.com/posts/1')
  .then(response => {
    const valor = response.data; // Aqui você pega o valor da resposta
    return valor; // Exibe o valor no console
  })
  .catch(error => {
    console.error('Erro na requisição:', error);
    return
  })
  const get  = Axios.get("http://localhost:5159/Start",{ headers: { "Access-Control-Allow-Origin": "*",
          "Access-Control-Allow-Headers": "Authorization", 
          "Access-Control-Allow-Methods": "GET, POST, OPTIONS, PUT, PATCH, DELETE" ,
          "Content-Type": "application/json;charset=UTF-8"} }).then(response => {
    const valor = response.data; // Aqui você pega o valor da resposta
    return valor; // Exibe o valor no console
  })
  .catch(error => {
    console.error('Erro na requisição:', error);
    return
  })

 function App() {
  const advice = GetAxios.title;
  console.log(advice)
  console.log(get)

  return (
    <div className="App">
      <header className="App-header">
        <p>
          hello world 
        </p>
        <p>
          {advice}
        </p>
      </header>
    </div>
  );
}

export default App;
