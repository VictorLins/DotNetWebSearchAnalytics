import { useEffect, useState } from 'react';
import './App.css';

function App() {
    const [searchHistory, setSearchHistory] = useState();
    const [url, setUrl] = useState("https://www.google.co.uk/search?");
    const [searchTerm, setSearchTerm] = useState("land+registry+search");


    const handleUrlChange = (event) => {
        setUrl(event.target.value);
    }

    const handleSearchTermChange = (event) => {
        setSearchTerm(event.target.value);
    }

    useEffect(() => {
        populateSearchHistory();
    }, []);

    const contents = searchHistory === undefined

        ? <div><p><em>Loading...</em></p> 
            <p><em>If there's a prolonged wait, please review the backend components</em></p></div>
        :
        <div className="container col-md-12">

            <h1>Search</h1>
            <div className="row mt-3">
                <div className="col-md-6">
                    <label htmlFor="searchTerm" className="form-label">Search Term</label>&nbsp;&nbsp;
                    <input type="text" className="form-control form-control-lg me-2" style={{ width: "20%" }} id="searchTerm" placeholder="Enter Search Term" value={searchTerm} onChange={handleSearchTermChange} />&nbsp;&nbsp;
                    <label htmlFor="url" className="form-label">URL</label>&nbsp;&nbsp;
                    <input type="text" className="form-control form-control-lg me-2" style={{ width: "30%" }} id="url" placeholder="Enter URL" value={url} onChange={handleUrlChange} />&nbsp;&nbsp;
                    <button type="button" className="btn btn-primary" onClick={handleClick}
                    >Search</button>
                </div>
                <div className="col-md-6">

                </div>
                <div className="col-md-12 mt-3">
                </div>
            </div>

            <h1>History</h1>
            <table className="table table-striped" aria-labelledby="tabelLabel">
                <thead>
                    <tr style={{ color: 'black' }}>
                        <th>#</th>
                        <th>Date</th>
                        <th>Engine</th>
                        <th>Search Term</th>
                        <th>Keyword</th>
                        <th>Quantity</th>
                        <th>Indices</th>
                    </tr>
                </thead>
                <tbody>
                    {searchHistory && searchHistory.map(searchHistoryEntry =>
                        <tr key={searchHistoryEntry.id} style={{ color: 'black' }}>
                            <td>{searchHistoryEntry.id}</td>
                            <td>{searchHistoryEntry.date_String}</td>
                            <td>{searchHistoryEntry.search_Engine}</td>
                            <td>{searchHistoryEntry.search_Term}</td>
                            <td>{searchHistoryEntry.keyword}</td>
                            <td>{searchHistoryEntry.result_Quantity}</td>
                            <td>{searchHistoryEntry.result_Positions}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        </div>

    return (
        <div>
            {contents}
        </div>
    );

    function handleClick() {
        fetch(`https://localhost:7138/api/SearchTransaction/SearchKeyword?prURL=${url}&prSearchTerm=${searchTerm}&prTakeResult=100&prKeyword=www.infotrack.co.uk`)
            .then(response => {
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                return response.json();
            })
            .then(data => {
                if (Array.isArray(data))
                    setSearchHistory(data);
                else (alert(data))

            })
            .catch(error => {
                console.error('There was a problem with the fetch operation:', error);
                alert('There was a problem with the fetch operation:', error)
            });
    }

    async function populateSearchHistory() {
        fetch(`https://localhost:7138/api/SearchTransaction/GetAll`)
            .then(response => {
                if (!response.ok) {
                    throw new Error('Network response was not ok');
                }
                return response.json();
            })
            .then(data => {
                console.log(data);
                setSearchHistory(data);

            })
            .catch(error => {
                console.error('There was a problem with the fetch operation:', error);
                alert('There was a problem with the fetch operation:', error)
            });
    }
}

export default App;