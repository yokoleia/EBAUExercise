
export default function renderStoresReport(ApiData) {
        return (
                <table className='table table-striped' aria-labelledby="tabelLabel">
                        <thead>
                                <tr>
                                        <th>Order Date</th>
                                        <th>Number of Orders</th>
                                        <th>Total Orders</th>
                                </tr>
                        </thead>
                        <tbody>
                                {ApiData.storesReport.map(storesReport =>
                                        <tr key={storesReport.orderDate}>
                                                <td>{storesReport.orderDate.split("T")[0]}</td>
                                                <td>{storesReport.orderCount}</td>
                                                <td>${
                                               Number(storesReport.orderTotal).toFixed(2)
                                                }</td>
                                        </tr>
                                )}
                        </tbody>
                </table>
        );
}