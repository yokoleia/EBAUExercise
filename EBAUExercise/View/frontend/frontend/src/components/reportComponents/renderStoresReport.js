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
                                                <td>{storesReport.orderDate}</td>
                                                <td>{storesReport.orderCount}</td>
                                                <td>${storesReport.orderTotal}</td>
                                        </tr>
                                )}
                        </tbody>
                </table>
        );
}