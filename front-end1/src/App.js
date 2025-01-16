
import axios from 'axios';
import './App.css';
import 'axios';
const GetAxios = async () => {
  try {
      const response = await axios.get('https://api.adviceslip.com/advice');

      const advice = await response.data;

      console.log(advice);

  } catch(err) {
      // TODO
      // adicionar tratamento da exceção
      console.error(err);
  }
};

function App() {
  console.log("oi");
  GetAxios();
  return (
    <div className="App">
      <header className="App-header">
        <p>
          hello world
        </p>
      </header>
    </div>
  );
}

export default App;
